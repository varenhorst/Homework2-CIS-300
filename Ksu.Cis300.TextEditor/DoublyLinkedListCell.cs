using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TextEditor
{
    public class DoublyLinkedListCell<T>
    {
        public T Data { get; set; } //Data property, of stype string in this case
        public DoublyLinkedListCell<T> Next { get; set; } //Next Property
        public DoublyLinkedListCell<T> Previous { get; set; } //Previous Property

    }
}
