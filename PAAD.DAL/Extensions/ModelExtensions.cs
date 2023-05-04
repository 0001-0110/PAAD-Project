﻿using PAAD.DAL.Models;
using System.Reflection;

namespace PAAD.DAL.Extensions
{
    internal static class ModelExtensions
    {
        public static void Edit<T>(this T model, T editedModel) where T : Model
        {
            foreach (PropertyInfo property in model.GetType().GetProperties())
            {
                // You can't edit the Id of a model
                if (property.Name != "Id")
                    property.SetValue(model, property.GetValue(editedModel));
            }
        }
    }
}
