﻿//// Copyright (c) Microsoft Corporation.
//// Licensed under the MIT license.


//namespace BlazorBindings.AvaloniaBindings.Elements;

//public partial class AttributeHelper
//{
//    private static readonly PointCollectionConverter _pointCollectionConverter = new();

//    public static PointCollection StringToPointCollection(object value)
//    {
//        return value switch
//        {
//            null => null,
//            PointCollection pointCollection => pointCollection,
//            Point[] pointArray => (PointCollection)pointArray,
//            string str => (PointCollection)_pointCollectionConverter.ConvertFromInvariantString(str),
//            _ => throw new ArgumentException("Cannot convert value to PointCollection.", nameof(value))
//        };
//    }
//}