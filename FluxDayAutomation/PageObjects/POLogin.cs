// Page Object Model for Login page

namespace FluxDayAutomation.PageObjects
{
    class POLogin : POGeneral
    {
        POLogin() : base("https://app.fluxday.io/")
        {
            base.AddElement("user_email", "inputbox");
            base.AddElement("user_password", "inputbox");
            base.AddElement("user_remember_me", "checkbox");
            base.AddElementByClass("btn-login", "button");
        }
    }
}
