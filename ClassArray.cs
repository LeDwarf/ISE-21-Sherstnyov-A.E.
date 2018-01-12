﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
	class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
	{
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public static int operator +(ClassArray<T> p, T cat)
        {
            var isCat = cat is Cat; 
            if(p.places.Count == p.maxCount)
            {
                throw new ParkingOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (cat.GetType() == p.places[i].GetType())
                {
                    if (isCat)
                    {
                        if ((cat as Cat).Equals(p.places[i]))
                        {
                            throw new ParkingAlreadyHaveException();
                        }
                    }
                    else if ((cat as Boat).Equals(p.places[i]))
                    {
                        throw new ParkingAlreadyHaveException();
                    }
                }                   
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, cat);
                return index;
            }
            p.places.Add(p.places.Count, cat);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T cat = p.places[index];
                p.places.Remove(index);
                return cat;
            }
            throw new ParkingIndexOutofrangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

        //Enumerator
        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        //enumerable
        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if(this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() > other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i= 0; i< this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is Boat &&
                        other.places[thisKeys[i]] is Cat)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is Cat &&
                        other.places[thisKeys[i]] is Boat)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is Boat &&
                        other.places[thisKeys[i]] is Boat)
                    {
                        return (this.places[thisKeys[i]] is Boat).CompareTo(other.places[thisKeys[i]] is Boat);
                    }
                    if (this.places[thisKeys[i]] is Cat &&
                        other.places[thisKeys[i]] is Cat)
                    {
                        return (this.places[thisKeys[i]] is Cat).CompareTo(other.places[thisKeys[i]] is Cat);
                    }
                }
            }
            return 0;
        }

    }
}
