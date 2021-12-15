using System;
using System.ComponentModel.DataAnnotations;

namespace Calculadora.Notations
{
    // Indentacion de las clases se deberia mejorar, ademas de que c�digo comentado no se deber�a subir al master.
    public class TitleToExport : ValidationAttribute
    {
        public readonly string Title;

        public readonly Type FormatType;

        public TitleToExport() { }

        public TitleToExport(string title) => Title = title;
    }
}