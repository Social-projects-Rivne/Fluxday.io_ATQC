// General Page Object Model

using System;
using System.Collections.Generic;

namespace FluxDayAutomation.PageObjects
{
    class POGeneral
    {
        private string url;                                                                                                         // page url
        private Dictionary<KeyValuePair<string, string>, string> elements = new Dictionary<KeyValuePair<string, string>, string>(); // key: element name; value: element type ("inputbox", "checkbox", etc); value2: search type ("id", "xpath", etc)

        public POGeneral(string URL)
        {
            url = URL;
        }

        // Adding an element to PO
        protected void AddElement(string Name, string ElementType, string SearchType)
        {
            var temp = new KeyValuePair<string, string>(Name, ElementType);
            elements.Add(temp, SearchType);
        }

        // Returns element's type or throws exception if unable to find
        public string GetElementType(string Name)
        {
            foreach (KeyValuePair<KeyValuePair<string, string>, string> keyValue in elements)
            {
                if (keyValue.Key.Key == Name)
                {
                    return keyValue.Key.Value;
                }
            }

            throw new Exception(this.ToString() + ": Element \"" + Name + "\" not found!");
        }

        // Checking presence of element on PO
        public bool IsElementPresent(string Name, string Type)
        {
            foreach (KeyValuePair<KeyValuePair<string, string>, string> keyValue in elements)
            {
                if (keyValue.Key.Key == Name && keyValue.Key.Value == Type)
                {
                    return true;
                }
            }

            return false;
        }

        // Returns PO's URL
        public string GetURL()
        {
            return url;
        }
    }
}
