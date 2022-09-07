﻿namespace Building
{
    //1. Реализовать класс для описания здания(уникальный номер здания, высота, этажность, количество квартир, подъездов).
    //Поля сделать закрытыми, предусмотреть методы для заполнения полей и получения значений полей для печати.
    //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже и т.д.
    //Предусмотреть возможность, чтобы уникальный номер здания генерировался программно.Для этого в классе предусмотреть статическое
    //поле, которое бы хранило последний использованный номер здания, и предусмотреть метод, который увеличивал бы значение этого поля.
    internal class StructBuilding: Building
    {
        public override float GetFloorHeight()
        {
            return GetHeight() / GetFloor();
        }

        public override void Print()
        {
            Console.WriteLine($"Уникальный номер здания: {GetNumber()}; высота: {GetHeight()}; этажность: {GetFloor()}; количество квартир: {GetFlat()}; количества подъездов: {GetEntrance()};" +
                $"высота квартиры{GetFloorHeight()}");
        }
    }
}
