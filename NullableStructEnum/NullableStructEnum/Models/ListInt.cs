using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructEnum.Models
{
    internal class ListInt
    {
        private int[] _arr;

        public int Length
        {
            get 
            {
                return _arr.Length;
            }
            
        }
        public int this[int index]
        {
            get
            {
                if (index >= _arr.Length)
                {
                    return _arr[_arr.Length - 1];
                }
                return _arr[index];
            }
            set
            {
                if (index<_arr.Length)
                {
                    _arr[index] = value;
                }
              
            }
        }
        public ListInt()
        {
            _arr = new int[0];
        }
        public ListInt(int length) 
        { 
            _arr = new int[length];
        
        }
        public ListInt(params int[] nums)
        {
            _arr = nums;
        }


        public void Add(int value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length-1] = value;
        }
    }
}
