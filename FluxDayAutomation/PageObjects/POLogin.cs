// Page Object Model for Login page

namespace FluxDayAutomation.PageObjects
{
    class POLogin : POGeneral
    {
        public POLogin() : base("https://app.fluxday.io/users/sign_in/")
        {
            AddElement("user_email", "inputbox", "id");
            AddElement("user_password", "inputbox", "id");
            AddElement("user_remember_me", "checkbox", "id");
            AddElement("btn-login", "button", "class");
        }
    }
}
