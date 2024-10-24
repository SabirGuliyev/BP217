using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructEnum.Models
{
    internal class CustomList<T>
    {
        private T[] _arr;

        public int Length
        {
            get 
            {
                return _arr.Length;
            }
            
        }
        public T this[int index]
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
        public CustomList()
        {
            _arr = new T[0];
        }
        public CustomList(int length) 
        { 
            _arr = new T[length];
        
        }
        public CustomList(params T[] nums)
        {
            _arr = nums;
        }


        public void Add(T value)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length-1] = value;
        }
    }
}
