using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatorCost
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        #region Properties

        public int NumberOfPeople { get; set; }

        public bool FancyDecorations { get; set; }

        public bool HealthyOption { get; set; }

        /// <summary>
        /// Now that the calculations are private and encapsulated behind the Cost property, there's no way for the form
        /// to recalculate the cost of the decorations that doesn't use the current options.
        /// </summary>
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += ((CalculateCostOfBeveragesPerPerson()
                + CostOfFoodPerPerson) * NumberOfPeople);
                if (HealthyOption)
                {
                    totalCost *= .95M;
                }
                return totalCost;
            }
        }
        
        #endregion

        #region Métodos

        // Construtor padrão
        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            HealthyOption = healthyOption;
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;

            if (FancyDecorations)
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            else
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;

            return costOfDecorations;
        }

        /// <summary>
        /// The private methods used in the cost calculation access the properties so that 
        /// they have the latest information from the form.
        /// </summary>
        /// <returns></returns>
        private decimal CalculateCostOfBeveragesPerPerson()
        {
            decimal costOfBeveragesPerPerson;
            if (HealthyOption)
            {
                costOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                costOfBeveragesPerPerson = 20.00M;
            }
            return costOfBeveragesPerPerson;
        }

        #endregion
    }
}
