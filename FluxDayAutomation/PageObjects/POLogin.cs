// Page Object Model for Login page

namespace FluxDayAutomation.PageObjects
{
    class POLogin : POGeneral
    {
        public POLogin() : base("https://app.fluxday.io/")
        {
            AddElement("user_email", "inputbox");
            AddElement("user_password", "inputbox");
            AddElement("user_remember_me", "checkbox");
            AddElementByClass("btn-login", "button");
        }
    }
}
