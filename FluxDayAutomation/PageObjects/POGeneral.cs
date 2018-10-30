// General Page Object Model

using System;
using System.Collections.Generic;

namespace FluxDayAutomation.PageObjects
{
    class POGeneral
    {
        private string url;                                                                     // page url
        private Dictionary<string, string> elements = new Dictionary<string, string>();         // key: element id; value: element type ("input", "checkbox", etc)
        private Dictionary<string, string> elementsByClass = new Dictionary<string, string>();  // key: element class; value: element type

        public POGeneral(string URL)
        {
            this.url = URL;
        }

        // Adding an element to PO
        protected void AddElement(string ID, string ElementType)    
        {
            elements.Add(ID, ElementType);
        }

        // Adding an element by it's class
        protected void AddElementByClass(string Class, string ElementType)  
        {
            elementsByClass.Add(Class, ElementType);
        }

        // Checking presence of element on PO
        public bool IsElementPresent(string ID)    
        {
            foreach (KeyValuePair<string, string> keyValue in elements)
            {
                if (keyValue.Key == ID)
                {
                    return true;
                }

            }
                
            return false;
        }

        // Checking presence of element on PO by class
        public bool IsElementPresentByClass(string Class)    
        {
            foreach (KeyValuePair<string, string> keyValue in elementsByClass)
            {
                if (keyValue.Key == Class)
                {
                    return true;
                }
            }

            return false;
        }

        // Returns element's type or throws exception if unable to find
        public string GetElementType(string ID)     
        {
            foreach (KeyValuePair<string, string> keyValue in elements)
            {
                if (keyValue.Key == ID)
                {
                    return keyValue.Value;
                }
            }
                
            throw new Exception(this.ToString() + ": Element \"" + ID + "\" not found!");
        }

        // Returns element's type (by element class) or throws exception if unable to find
        public string GetElementTypeByClass(string Class)    
        {
            foreach (KeyValuePair<string, string> keyValue in elementsByClass)
            {
                if (keyValue.Key == Class)
                {
                    return keyValue.Value;
                }
            }

            throw new Exception(this.ToString() + ": Element with class \"" + Class + "\" not found!");
        }

        // Returns PO's URL
        public string GetURL()
        {
            return this.url;
        }
    }
}
