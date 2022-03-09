﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_Collections
{
        internal class Contact
        {

            //list is created to store contact info
            List<Contact> contacts = new List<Contact>();

            //variables
            public string first_name;
            public string last_name;
            public string address;
            public string city;
            public string state;
            public int zip;
            public long phone;
            public string email;

            /// <summary>
            /// Initializes a new instance of the <see cref="Contacts"/> class.
            /// </summary>
            public Contact()
            {

            }

            /// <summary>
            /// Initializes a new instance of the <see cref="Contacts"/> class.
            /// </summary>
            /// <param name="first_name">The first name.</param>
            /// <param name="last_name">The last name.</param>
            /// <param name="address">The address.</param>
            /// <param name="city">The city.</param>
            /// <param name="state">The state.</param>
            /// <param name="zip">The zip.</param>
            /// <param name="phone">The phone.</param>
            /// <param name="email">The email.</param>
            public Contact(string first_name, string last_name, string address, string city, string state, int zip, long phone, string email)
            {
                this.first_name = first_name;
                this.last_name = last_name;
                this.address = address;
                this.city = city;
                this.state = state;
                this.zip = zip;
                this.phone = phone;
                this.email = email;
            }

            /// <summary>
            /// Sets the contacts.
            /// </summary>
            /// <param name="contacts">The contacts.</param>
            public void setContacts(List<Contact> contacts)
            {
                this.contacts = contacts;
            }

            /// <summary>
            /// Gets the contacts.
            /// </summary>
            /// <returns></returns>
            public List<Contact> getContacts()
            {
                return contacts;
            }

            /// <summary>
            /// Shows the contacts.
            /// </summary>
            /// <returns></returns>
            public List<Contact> showContacts()
            {
                return contacts;
            }

            /// <summary>
            /// Converts to string.
            /// </summary>
            /// <returns>
            /// A <see cref="System.String" /> that represents this instance.
            /// </returns>
            public override string ToString()
            {
                return "First Name: " + first_name + " \n" + "Last Name: " + last_name + " \n" + "Address: " + address + " \n" + "City: " + city + " \n" + "State: " + state + " \n" + "Zip: " + zip + " \n" + "Phone Number: " + phone + " \n" + "Email-id: " + email;
            }

        }
    }
