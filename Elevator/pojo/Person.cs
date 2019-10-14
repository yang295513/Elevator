using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Elevator.pojo
{
    class Person
    {
        /// <summary>
        /// 电梯人的bean对象
        /// 有唯一标识id和name名字属性和weight体重属性
        /// </summary>
        /// <value name='id'>唯一标识</value>
        /// <value name='name'>姓名</value>
        /// <value name='weight'>体重</value>
        private int id { get; set; }
        private string name { get; set; }
        private double weight { get; set; }

        Person(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        Person(int id,string name,double weight)
        {
            this.id = id;
            this.name = name;
            this.weight = weight;
        }
    }
}
