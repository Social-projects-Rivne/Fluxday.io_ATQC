// General Page Object Model

using System;
using System.Collections.Generic;

namespace FluxDayAutomation.PageObjects
{
    class POGeneral
    {
        private string url; //page url
        private Dictionary<string, string> elements = new Dictionary<string, string>();     // key: element id; value: element type ("input", "checkbox", etc)
        private Dictionary<string, string> elementsByClass = new Dictionary<string, string>();  // key: element class; value: element type

        public POGeneral(string URL)
        {
            this.url = URL;
        }

        protected void AddElement(string ID, string ElementType)    // Adding an element to PO
        {
            elements.Add(ID, ElementType);
        }

        protected void AddElementByClass(string Class, string ElementType)  // Adding an element by it's class
        {
            elementsByClass.Add(Class, ElementType);
        }

        public bool IsElementPresent(string ID)    // Checking presence of element on PO
        {
            foreach (KeyValuePair<string, string> keyValue in elements)
                if (keyValue.Key == ID)
                    return true;

            return false;
        }

        public bool IsElementPresentByClass(string Class)    // Checking presence of element on PO by class
        {
            foreach (KeyValuePair<string, string> keyValue in elementsByClass)
                if (keyValue.Key == Class)
                    return true;

            return false;
        }

        public string GetElementType(string ID)     // Returns element's type or throws exception if unable to find
        {
            foreach (KeyValuePair<string, string> keyValue in elements)
                if (keyValue.Key == ID)
                    return keyValue.Value;

            throw new Exception(this.ToString() + ": Element \"" + ID + "\" not found!");
        }

        public string GetElementTypeByClass(string Class)     // Returns element's type (by element class) or throws exception if unable to find
        {
            foreach (KeyValuePair<string, string> keyValue in elementsByClass)
                if (keyValue.Key == Class)
                    return keyValue.Value;

            throw new Exception(this.ToString() + ": Element with class \"" + Class + "\" not found!");
        }

        public string GetURL()
        {
            return this.url;
        }
    }
}
