using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgileHubCursProiectUI.PageObjects
{
    partial class BuyShoesOtherPages
    {
        public void SelectReturnOption()
        {
            ExchangesReturnButton.Click();
        }
        public void ChooseReturnPolicy()
        {
            Helper.ScrollToSeeTheRightButton(_driver, ReturnPolicyButton);
            ReturnPolicyButton.Click();
        }
        public void SeeReturnPolicy()
        {
            Helper.ScrollToSeeTheRightButton(_driver, ReturnQuestionyButton);
            ReturnQuestionyButton.Click();
        }
        public bool IsCanIExchangeMyProductDisplayed()
        {
            return ExchangeMyProductText.Displayed;
        }
    }
}
