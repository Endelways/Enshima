using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
public interface IItem
{
    int Id { get; }
    string Name { get; }
    string Description { get; }
    //string Type { get; }
    Sprite Icon { get; }
}

