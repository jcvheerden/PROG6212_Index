using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoggyDayCare_Icetask1
{
    public class Doggo
    {
        //Declaration
        int age, dogWeight, dogKennel;
        string dogBreed, dogName;


        public Doggo(int age, int dogWeight, int dogKennel, string dogBreed, string dogName)
        {
            this.age = age;
            this.dogWeight = dogWeight;
            this.dogKennel = dogKennel;
            this.dogBreed = dogBreed;
            this.dogName = dogName;
           
        }

        public object this[int index] //Number index
        {
            get
            {
                if (index == 0)
                    return this.age;
                else if (index == 1)
                    return this.dogWeight;
                else if (index == 2)
                    return this.dogKennel;
                else if (index == 3)
                     return this.dogBreed;
                else if (index == 4)     
                    return this.dogName;
                return null;

            }

            set
            {

                if (index == 0)
                    this.age = (int)value;
                else if (index == 1)
                    this.dogWeight = (int)value;
                else if (index == 2)
                    this.dogKennel = (int)value;
                else if (index == 3)
                    this.dogBreed = (string)value;
                else if (index == 4)  
                    this.dogName = (string)value;

            }





        }

        public object this[string attrName] //"String value"
        {
            get
            {
                if (attrName.ToLower().Equals("age"))
                    return this.age;
                if (attrName.ToLower().Equals("weight"))
                    return this.dogWeight;
                if (attrName.ToLower().Equals("kennel"))
                    return this.dogKennel;

                if (attrName.ToLower().Equals("breed"))
                    return this.dogBreed;
                if (attrName.ToLower().Equals("name"))
                    return this.dogName;
                
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("age"))
                    this.age = (int)value;
                if (attrName.ToLower().Equals("weight"))
                    this.dogWeight = (int)value;
                if (attrName.ToLower().Equals("kennel"))
                    this.dogKennel = (int)value;
                if (attrName.ToLower().Equals("breed"))
                    this.dogBreed = (string)value;
                if (attrName.ToLower().Equals("name"))
                    this.dogName = (string)value;
                

            }



        }



    }
}
