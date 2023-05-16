﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infra.Persistence.Context.Converter
{
    internal class DateOnlyConverter : ValueConverter<DateOnly, DateTime>
    {
        public DateOnlyConverter() : base(dateOnly => dateOnly.ToDateTime(TimeOnly.MinValue), dateTime => DateOnly.FromDateTime(dateTime))
        { 

        }
    }
}
