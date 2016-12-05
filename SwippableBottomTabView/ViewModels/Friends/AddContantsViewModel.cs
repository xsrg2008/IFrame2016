using Plugin.Contacts;
using Plugin.Contacts.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IFrame.ViewModels.Friends
{
    public class AddContantsViewModel
    {
        public List<Contact> contacts;
        public AddContantsViewModel()
        {
            CrossContacts.Current.RequestPermission();
            if (true)
            {

                contacts = null;
                CrossContacts.Current.PreferContactAggregation = false;//recommended
                                                                       //run in background
                Task.Run(() =>
                {
                    if (CrossContacts.Current.Contacts == null)
                        return;

                    contacts = CrossContacts.Current.Contacts
                      .Where(c => !string.IsNullOrWhiteSpace(c.LastName) && c.Phones.Count > 0)
                      .ToList();

                    contacts = contacts.OrderBy(c => c.LastName).ToList();
                });
            }
        }
    }
}
