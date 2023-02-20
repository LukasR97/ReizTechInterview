using ReizInterview.KasNors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ReizInterview
{
    internal class CollectionOfItems
    {
        private List<Item> items;

        public CollectionOfItems()
        {
            Item item = new Item(1,"item1");
            Item item1 = new Item(2,"item2");
            Item item2 = new Item(3, "item3");

            items = new List<Item>();
            items.Add(item);
            items.Add(item1);
            items.Add(item2);
        }

        public GetItemNameByIdResponse GetItemNameById(int id)
        {
            GetItemNameByIdResponse result = new GetItemNameByIdResponse();

            try
            {
                result.ItemName = items.FirstOrDefault(x => x.Id == id).Title;
                result.IsSuccessful = true;
                return result;
            }
            catch(Exception ex)
            {
                result.Error = "There is no Item with the given Id";
                result.IsSuccessful = false;
                return result;
            }
        }
    }
}
