/*
 * Author: Katherine Bellman, Russell Waring
 * Date: July 15, 2021
 * Revision: August 13, 2021
 * Title: Lab 6: MDI
 * Sub-title: Contact Class Definition
 */

using System;
using System.Collections.Generic;


namespace Lab6MDI
{
    class Contact
    {
        #region PROPERTIES

        public Boolean ContactStatus { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public DateTime Date { get; set; }

        public String Email { get; set; }

        public String Phone { get; set; }


        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// Default Constructor for a contact.
        /// </summary>
        public Contact() {}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contactstatus"></param>
        /// <param name="firstName">First name of contact</param>
        /// <param name="lastName">Last name of the contact</param>
        /// <param name="date">Date of contact creation</param>
        /// <param name="email">Contact email</param>
        /// <param name="phone">Contact phone number</param>
        public Contact(Boolean contactStatus, String firstName, String lastName, DateTime date, String email, String phone)
        {
            ContactStatus = contactStatus;
            FirstName = firstName;
            LastName = lastName;
            Date = date;
            Email = email;
            Phone = phone;
        }
        #endregion

        #region OBJECT METHODS
        #endregion

        #region STATIC METHODS

        public static List<Contact> GenerateTestContacts()
        {
            List<Contact> returnContacts = new List<Contact>();

            returnContacts.Add(new Contact(true, "Bart", "Simpson", new DateTime(2008, 11, 11), "donthaveacow@hotmail.com", "9059040011"));
            returnContacts.Add(new Contact(false, "Ned", "Flanders", new DateTime(2012, 02, 15), "hineighbour@gmail.com", "7057451234"));
            returnContacts.Add(new Contact(true, "Barney", "Gumble", new DateTime(2001, 03, 28), "wahwahwah@outlook.com", null));

            return returnContacts;
        }

        public static Contact GetContactFromName(List<Contact> inputContacts, String firstName, String lastName)
        {
            Contact returnContact = new Contact();

            // code to iterate through the list of contactss to find one with matching phone number.
            foreach (Contact contact in inputContacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    returnContact = contact;
                    break;
                }
            }

            return returnContact;
        }

        public static Boolean AlreadyExists(List<Contact> inputContacts, String firstName, String lastName)
        {
            Boolean returnValue = false;

            foreach (Contact contact in inputContacts)
            {
                if (contact.FirstName == firstName && contact.LastName == lastName)
                {
                    returnValue = true;
                    break;
                }
            }
            return returnValue;
        }

        #endregion
    }
}
