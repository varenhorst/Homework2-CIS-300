using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.TextEditor
{
    class KillRing
    {
        private DoublyLinkedListCell<string> _topCell = null; //header of killring
        private DoublyLinkedListCell<string> _lastYank = null; //Last Yank
        private int _capacity = 10; // capacity of kill ring
        private int _count = 0;  // number of kills

        public int Capacity
        {
            get
            {
                return _capacity;
            }
            set
            {
                _capacity = value;
                if (_capacity < _count)
                {
                    // Remove excess cells from the ring.
                    // Step through the rin, counting the cells to find the last cell you want to keep
                    // Change the next property and a previous property to cut out the excess cells
                    int i = 1;
                    DoublyLinkedListCell<string> temp = _topCell;
                    while (temp.Next != null)
                    {
                        if (i == _capacity)
                        {
                            temp.Next = _topCell;
                            _topCell.Previous = temp;
                            break;
                        }
                        temp = temp.Next;
                        i++;
                    }
                }
            }
        }

        //killAdd = kill to add to the kill ring
        public void Add(string killAdd)
        {
            if (_count == 0)
            {
                //build a single-cell kill ring

                _topCell = new DoublyLinkedListCell<string>();
                _topCell.Next = _topCell;
                _topCell.Previous = _topCell;
                _topCell.Data = killAdd;
                _count = 1; //update count
            }
            else if (_count > 0 && _count < _capacity)
            {
                //insert a new cell into the ring. This cell will be the new top of the ring
                DoublyLinkedListCell<string> newCell = new DoublyLinkedListCell<string>();

                newCell.Previous = _topCell.Previous;
                _topCell.Previous.Next = newCell;
                newCell.Next = _topCell;
                _topCell = newCell;
                _topCell.Data = killAdd;
                _count++; //update count
            }
            else if (_count == _capacity)
            {
                //Change top of the ring to the earliest kill.
                //  - store Kill in this cell
                _topCell = _topCell.Previous;
                _topCell.Data = killAdd;   
            }
        }

        //updates the last yank to the top of the ring and return the data stored in this cell.
        public string Yank()
        {
            _lastYank = _topCell;
            return _lastYank.Data;
        }

        //Updates the last yank and return the appropriate kill.
        public string YankPrevious()
        {
            _lastYank = _lastYank.Next;
            return _lastYank.Data;
        }
    }
}
