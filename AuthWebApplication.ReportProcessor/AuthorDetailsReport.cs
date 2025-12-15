using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using FastReport;
using FastReport.Data;
using FastReport.Dialog;
using FastReport.Barcode;
using FastReport.Table;
using FastReport.Utils;

namespace FastReport
{
  public class AuthorDetailsReport : Report
  {
    public FastReport.Report Report;
    public FastReport.Engine.ReportEngine Engine;
    public FastReport.DataBand Data1;
    public FastReport.GroupFooterBand GroupFooter1;
    public FastReport.GroupHeaderBand GroupHeader1;
    public FastReport.ReportPage Page1;
    public FastReport.PageFooterBand PageFooter1;
    public FastReport.ReportTitleBand ReportTitle1;
    public FastReport.TextObject Text1;
    public FastReport.TextObject Text10;
    public FastReport.TextObject Text11;
    public FastReport.TextObject Text12;
    public FastReport.TextObject Text13;
    public FastReport.TextObject Text14;
    public FastReport.TextObject Text15;
    public FastReport.TextObject Text16;
    public FastReport.TextObject Text17;
    public FastReport.TextObject Text18;
    public FastReport.TextObject Text19;
    public FastReport.TextObject Text2;
    public FastReport.TextObject Text3;
    public FastReport.TextObject Text4;
    public FastReport.TextObject Text5;
    public FastReport.TextObject Text6;
    public FastReport.TextObject Text7;
    public FastReport.TextObject Text8;
    public FastReport.TextObject Text9;
    protected override object CalcExpression(string expression, Variant Value)
    {
      if (expression == "50")
        return 50;
      return null;
    }

    private SByte Abs(SByte value)
    {
      return System.Math.Abs(value);
    }

    private Int16 Abs(Int16 value)
    {
      return System.Math.Abs(value);
    }

    private Int32 Abs(Int32 value)
    {
      return System.Math.Abs(value);
    }

    private Int64 Abs(Int64 value)
    {
      return System.Math.Abs(value);
    }

    private Single Abs(Single value)
    {
      return System.Math.Abs(value);
    }

    private Double Abs(Double value)
    {
      return System.Math.Abs(value);
    }

    private Decimal Abs(Decimal value)
    {
      return System.Math.Abs(value);
    }

    private Double Acos(Double d)
    {
      return System.Math.Acos(d);
    }

    private Double Asin(Double d)
    {
      return System.Math.Asin(d);
    }

    private Double Atan(Double d)
    {
      return System.Math.Atan(d);
    }

    private Double Ceiling(Double a)
    {
      return System.Math.Ceiling(a);
    }

    private Decimal Ceiling(Decimal d)
    {
      return System.Math.Ceiling(d);
    }

    private Double Cos(Double d)
    {
      return System.Math.Cos(d);
    }

    private Double Exp(Double d)
    {
      return System.Math.Exp(d);
    }

    private Double Floor(Double d)
    {
      return System.Math.Floor(d);
    }

    private Decimal Floor(Decimal d)
    {
      return System.Math.Floor(d);
    }

    private Double Log(Double d)
    {
      return System.Math.Log(d);
    }

    private Int32 Maximum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int64 Maximum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Single Maximum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Double Maximum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Decimal Maximum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Maximum(val1, val2);
    }

    private Int32 Minimum(Int32 val1, Int32 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Int64 Minimum(Int64 val1, Int64 val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Single Minimum(Single val1, Single val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Minimum(Double val1, Double val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Decimal Minimum(Decimal val1, Decimal val2)
    {
      return FastReport.Functions.StdFunctions.Minimum(val1, val2);
    }

    private Double Round(Double a)
    {
      return System.Math.Round(a);
    }

    private Decimal Round(Decimal d)
    {
      return System.Math.Round(d);
    }

    private Double Round(Double value, Int32 digits)
    {
      return System.Math.Round(value, digits);
    }

    private Decimal Round(Decimal d, Int32 decimals)
    {
      return System.Math.Round(d, decimals);
    }

    private Double Sin(Double a)
    {
      return System.Math.Sin(a);
    }

    private Double Sqrt(Double d)
    {
      return System.Math.Sqrt(d);
    }

    private Double Tan(Double a)
    {
      return System.Math.Tan(a);
    }

    private Double Truncate(Double d)
    {
      return System.Math.Truncate(d);
    }

    private Decimal Truncate(Decimal d)
    {
      return System.Math.Truncate(d);
    }

    private Int32 Asc(Char c)
    {
      return FastReport.Functions.StdFunctions.Asc(c);
    }

    private Char Chr(Int32 i)
    {
      return FastReport.Functions.StdFunctions.Chr(i);
    }

    private Boolean Contains(String s, String value)
    {
      return FastReport.Functions.StdFunctions.Contains(s, value);
    }

    private String Insert(String s, Int32 startIndex, String value)
    {
      return FastReport.Functions.StdFunctions.Insert(s, startIndex, value);
    }

    private Int32 Length(String s)
    {
      return FastReport.Functions.StdFunctions.Length(s);
    }

    private String LowerCase(String s)
    {
      return FastReport.Functions.StdFunctions.LowerCase(s);
    }

    private String PadLeft(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth);
    }

    private String PadLeft(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadLeft(s, totalWidth, paddingChar);
    }

    private String PadRight(String s, Int32 totalWidth)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth);
    }

    private String PadRight(String s, Int32 totalWidth, Char paddingChar)
    {
      return FastReport.Functions.StdFunctions.PadRight(s, totalWidth, paddingChar);
    }

    private String Remove(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex);
    }

    private String Remove(String s, Int32 startIndex, Int32 count)
    {
      return FastReport.Functions.StdFunctions.Remove(s, startIndex, count);
    }

    private String Replace(String s, String oldValue, String newValue)
    {
      return FastReport.Functions.StdFunctions.Replace(s, oldValue, newValue);
    }

    private String Substring(String s, Int32 startIndex)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex);
    }

    private String Substring(String s, Int32 startIndex, Int32 length)
    {
      return FastReport.Functions.StdFunctions.Substring(s, startIndex, length);
    }

    private String TitleCase(String s)
    {
      return FastReport.Functions.StdFunctions.TitleCase(s);
    }

    private String Trim(String s)
    {
      return FastReport.Functions.StdFunctions.Trim(s);
    }

    private String UpperCase(String s)
    {
      return FastReport.Functions.StdFunctions.UpperCase(s);
    }

    private DateTime AddDays(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddDays(date, value);
    }

    private DateTime AddHours(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddHours(date, value);
    }

    private DateTime AddMinutes(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddMinutes(date, value);
    }

    private DateTime AddMonths(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddMonths(date, value);
    }

    private DateTime AddSeconds(DateTime date, Double value)
    {
      return FastReport.Functions.StdFunctions.AddSeconds(date, value);
    }

    private DateTime AddYears(DateTime date, Int32 value)
    {
      return FastReport.Functions.StdFunctions.AddYears(date, value);
    }

    private TimeSpan DateDiff(DateTime date1, DateTime date2)
    {
      return FastReport.Functions.StdFunctions.DateDiff(date1, date2);
    }

    private DateTime DateSerial(Int32 year, Int32 month, Int32 day)
    {
      return FastReport.Functions.StdFunctions.DateSerial(year, month, day);
    }

    private Int32 Day(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Day(date);
    }

    private String DayOfWeek(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfWeek(date);
    }

    private Int32 DayOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.DayOfYear(date);
    }

    private Int32 DaysInMonth(Int32 year, Int32 month)
    {
      return FastReport.Functions.StdFunctions.DaysInMonth(year, month);
    }

    private Int32 Hour(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Hour(date);
    }

    private Int32 Minute(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Minute(date);
    }

    private Int32 Month(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Month(date);
    }

    private String MonthName(Int32 month)
    {
      return FastReport.Functions.StdFunctions.MonthName(month);
    }

    private Int32 Second(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Second(date);
    }

    private Int32 WeekOfYear(DateTime date)
    {
      return FastReport.Functions.StdFunctions.WeekOfYear(date);
    }

    private Int32 Year(DateTime date)
    {
      return FastReport.Functions.StdFunctions.Year(date);
    }

    private String Format(String format, params Object[] args)
    {
      return FastReport.Functions.StdFunctions.Format(format, args);
    }

    private String FormatCurrency(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value);
    }

    private String FormatCurrency(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatCurrency(value, decimalDigits);
    }

    private String FormatDateTime(DateTime value)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value);
    }

    private String FormatDateTime(DateTime value, String format)
    {
      return FastReport.Functions.StdFunctions.FormatDateTime(value, format);
    }

    private String FormatNumber(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value);
    }

    private String FormatNumber(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatNumber(value, decimalDigits);
    }

    private String FormatPercent(Object value)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value);
    }

    private String FormatPercent(Object value, Int32 decimalDigits)
    {
      return FastReport.Functions.StdFunctions.FormatPercent(value, decimalDigits);
    }

    private Boolean ToBoolean(Object value)
    {
      return System.Convert.ToBoolean(value);
    }

    private Byte ToByte(Object value)
    {
      return System.Convert.ToByte(value);
    }

    private Char ToChar(Object value)
    {
      return System.Convert.ToChar(value);
    }

    private DateTime ToDateTime(Object value)
    {
      return System.Convert.ToDateTime(value);
    }

    private Decimal ToDecimal(Object value)
    {
      return System.Convert.ToDecimal(value);
    }

    private Double ToDouble(Object value)
    {
      return System.Convert.ToDouble(value);
    }

    private Int32 ToInt32(Object value)
    {
      return System.Convert.ToInt32(value);
    }

    private String ToRoman(Object value)
    {
      return FastReport.Functions.StdFunctions.ToRoman(value);
    }

    private Single ToSingle(Object value)
    {
      return System.Convert.ToSingle(value);
    }

    private String ToString(Object value)
    {
      return System.Convert.ToString(value);
    }

    private String ToWords(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWords(value);
    }

    private String ToWords(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, decimalPartToWord);
    }

    private String ToWords(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName);
    }

    private String ToWords(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, currencyName, decimalPartToWord);
    }

    private String ToWords(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many);
    }

    private String ToWords(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWords(value, one, many, decimalPartToWord);
    }

    private String ToWordsIn(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value);
    }

    private String ToWordsIn(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, decimalPartToWord);
    }

    private String ToWordsIn(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, currencyName);
    }

    private String ToWordsIn(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, currencyName, decimalPartToWord);
    }

    private String ToWordsIn(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, one, many);
    }

    private String ToWordsIn(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsIn(value, one, many, decimalPartToWord);
    }

    private String ToWordsDe(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value);
    }

    private String ToWordsDe(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, decimalPartToWord);
    }

    private String ToWordsDe(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, currencyName);
    }

    private String ToWordsDe(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, currencyName, decimalPartToWord);
    }

    private String ToWordsDe(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, one, many);
    }

    private String ToWordsDe(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsDe(value, one, many, decimalPartToWord);
    }

    private String ToWordsEnGb(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value);
    }

    private String ToWordsEnGb(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, decimalPartToWord);
    }

    private String ToWordsEnGb(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName);
    }

    private String ToWordsEnGb(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, currencyName, decimalPartToWord);
    }

    private String ToWordsEnGb(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many);
    }

    private String ToWordsEnGb(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEnGb(value, one, many, decimalPartToWord);
    }

    private String ToWordsEs(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value);
    }

    private String ToWordsEs(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, decimalPartToWord);
    }

    private String ToWordsEs(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName);
    }

    private String ToWordsEs(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, currencyName, decimalPartToWord);
    }

    private String ToWordsEs(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many);
    }

    private String ToWordsEs(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsEs(value, one, many, decimalPartToWord);
    }

    private String ToWordsFr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value);
    }

    private String ToWordsFr(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, decimalPartToWord);
    }

    private String ToWordsFr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, currencyName);
    }

    private String ToWordsFr(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, currencyName, decimalPartToWord);
    }

    private String ToWordsFr(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, one, many);
    }

    private String ToWordsFr(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsFr(value, one, many, decimalPartToWord);
    }

    private String ToWordsNl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value);
    }

    private String ToWordsNl(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, decimalPartToWord);
    }

    private String ToWordsNl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, currencyName);
    }

    private String ToWordsNl(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, currencyName, decimalPartToWord);
    }

    private String ToWordsNl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, one, many);
    }

    private String ToWordsNl(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsNl(value, one, many, decimalPartToWord);
    }

    private String ToWordsRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value);
    }

    private String ToWordsRu(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, decimalPartToWord);
    }

    private String ToWordsRu(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName);
    }

    private String ToWordsRu(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, currencyName, decimalPartToWord);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many);
    }

    private String ToWordsRu(Object value, Boolean male, String one, String two, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsRu(value, male, one, two, many, decimalPartToWord);
    }

    private String ToWordsUkr(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value);
    }

    private String ToWordsUkr(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, decimalPartToWord);
    }

    private String ToWordsUkr(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, currencyName);
    }

    private String ToWordsUkr(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, currencyName, decimalPartToWord);
    }

    private String ToWordsUkr(Object value, Boolean male, String one, String two, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, male, one, two, many);
    }

    private String ToWordsUkr(Object value, Boolean male, String one, String two, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsUkr(value, male, one, two, many, decimalPartToWord);
    }

    private String ToWordsSp(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value);
    }

    private String ToWordsSp(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, decimalPartToWord);
    }

    private String ToWordsSp(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, currencyName);
    }

    private String ToWordsSp(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, currencyName, decimalPartToWord);
    }

    private String ToWordsSp(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, one, many);
    }

    private String ToWordsSp(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsSp(value, one, many, decimalPartToWord);
    }

    private String ToWordsPersian(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value);
    }

    private String ToWordsPersian(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, decimalPartToWord);
    }

    private String ToWordsPersian(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, currencyName);
    }

    private String ToWordsPersian(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, currencyName, decimalPartToWord);
    }

    private String ToWordsPersian(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, one, many);
    }

    private String ToWordsPersian(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPersian(value, one, many, decimalPartToWord);
    }

    private String ToWordsPl(Object value)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value);
    }

    private String ToWordsPl(Object value, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, decimalPartToWord);
    }

    private String ToWordsPl(Object value, String currencyName)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, currencyName);
    }

    private String ToWordsPl(Object value, String currencyName, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, currencyName, decimalPartToWord);
    }

    private String ToWordsPl(Object value, String one, String many)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, one, many);
    }

    private String ToWordsPl(Object value, String one, String many, Boolean decimalPartToWord)
    {
      return FastReport.Functions.StdFunctions.ToWordsPl(value, one, many, decimalPartToWord);
    }

    private String ToLetters(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value);
    }

    private String ToLetters(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLetters(value, isUpper);
    }

    private String ToLettersRu(Object value)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value);
    }

    private String ToLettersRu(Object value, Boolean isUpper)
    {
      return FastReport.Functions.StdFunctions.ToLettersRu(value, isUpper);
    }

    private Object Choose(Double index, params Object[] choice)
    {
      return FastReport.Functions.StdFunctions.Choose(index, choice);
    }

    private Object IIf(Boolean expression, Object truePart, Object falsePart)
    {
      return FastReport.Functions.StdFunctions.IIf(expression, truePart, falsePart);
    }

    private Object Switch(params Object[] expressions)
    {
      return FastReport.Functions.StdFunctions.Switch(expressions);
    }

    private Boolean IsNull(String name)
    {
      return FastReport.Functions.StdFunctions.IsNull(Report, name);
    }

    private Object IfNull(Object expression, Object defaultValue)
    {
      return FastReport.Functions.StdFunctions.IfNull(expression, defaultValue);
    }

    private void InitializeComponent()
    {
      string reportString = 
        "﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Report ScriptLanguage=\"CSharp\" ReportI" +
        "nfo.Created=\"12/30/2025 17:18:24\" ReportInfo.Modified=\"12/30/2025 17:23:27\" Repo" +
        "rtInfo.CreatorVersion=\"2026.1.0.0\">\r\n  <Styles Name=\"Standard\">\r\n    <Style Name" +
        "=\"Title\" Font=\"Arial, 12pt, style=Bold\"/>\r\n    <Style Name=\"Header\" Font=\"Arial," +
        " 10pt, style=Bold\"/>\r\n    <Style Name=\"Group\" Font=\"Arial, 10pt, style=Bold\"/>\r\n" +
        "    <Style Name=\"Data\" Font=\"Arial, 10pt\"/>\r\n    <Style Name=\"Footer\" Font=\"Aria" +
        "l, 10pt\"/>\r\n    <Style Name=\"EvenRows\" Fill.Color=\"WhiteSmoke\" Font=\"Arial, 10pt" +
        "\"/>\r\n  </Styles>\r\n  <Dictionary>\r\n    <MsSqlDataConnection Name=\"Connection\" Con" +
        "nectionString=\"rijcmlqGXkGkgEAxaTYdgorv35YdRQNawxt6DTl//zdnnxdmShM3WtMtjHtKw9i4H" +
        "M4i7fLuv2z15sIqrtNqmbZHHDOaSIdxzgK3gUfVtbKwzlsbft8i3I5qvAYwRQUOEOf5JY85RIXwrYwWm" +
        "DIBCAMI24VAtYN1PjQ7ExOR6o13xb8QYSPcYE3QW2ALd1HihwBQl2QcQUsMOUfvVJcf6hwvXTNtzGJq7" +
        "U61mO7J1DP0RJQRec=\">\r\n      <ProcedureDataSource Name=\"sp_GetAuthorDetails\" Data" +
        "Type=\"System.Int32\" Enabled=\"true\" TableName=\"sp_GetAuthorDetails\" SelectCommand";
      reportString += "=\"sp_GetAuthorDetails\">\r\n        <Column Name=\"Id\" DataType=\"System.Int32\"/>\r\n  " +
        "      <Column Name=\"AuthorName\" DataType=\"System.String\"/>\r\n        <Column Name" +
        "=\"Photo\" DataType=\"System.String\"/>\r\n        <Column Name=\"ISBN\" DataType=\"Syste" +
        "m.String\"/>\r\n        <Column Name=\"Title\" DataType=\"System.String\"/>\r\n        <C" +
        "olumn Name=\"Edition\" DataType=\"System.Int32\"/>\r\n        <Column Name=\"PublishDat" +
        "e\" DataType=\"System.DateTime\"/>\r\n        <Column Name=\"Genre\" DataType=\"System.I" +
        "nt32\"/>\r\n        <Column Name=\"AuthorId\" DataType=\"System.Int32\"/>\r\n        <Col" +
        "umn Name=\"Available\" DataType=\"System.Boolean\" BindableControl=\"CheckBox\"/>\r\n   " +
        "     <ProcedureParameter Name=\"@authorid\" DataType=\"8\" Expression=\"[AuthorID]\" D" +
        "irection=\"Input\"/>\r\n      </ProcedureDataSource>\r\n    </MsSqlDataConnection>\r\n  " +
        "  <Parameter Name=\"AuthorID\" DataType=\"System.Int32\" Expression=\"50\"/>\r\n  </Dict" +
        "ionary>\r\n  <ReportPage Name=\"Page1\" Watermark.Font=\"Arial, 60pt\">\r\n    <ReportTi";
      reportString += "tleBand Name=\"ReportTitle1\" Width=\"718.2\" Height=\"37.8\">\r\n      <TextObject Name" +
        "=\"Text1\" Width=\"718.2\" Height=\"37.8\" Dock=\"Fill\" Text=\"sp_GetAuthorDetails\" Horz" +
        "Align=\"Center\" VertAlign=\"Center\" Font=\"Arial, 12pt, style=Bold\" Style=\"Title\"/>" +
        "\r\n    </ReportTitleBand>\r\n    <GroupHeaderBand Name=\"GroupHeader1\" Top=\"43.13\" W" +
        "idth=\"718.2\" Height=\"18.9\" Condition=\"[sp_GetAuthorDetails.Genre]\">\r\n      <Text" +
        "Object Name=\"Text18\" Width=\"718.2\" Height=\"18.9\" Dock=\"Fill\" Text=\"[sp_GetAuthor" +
        "Details.Genre]\" Font=\"Arial, 10pt, style=Bold\" Style=\"Group\"/>\r\n      <DataBand " +
        "Name=\"Data1\" Top=\"67.37\" Width=\"718.2\" Height=\"160.65\" DataSource=\"sp_GetAuthorD" +
        "etails\">\r\n        <TextObject Name=\"Text2\" Width=\"103.95\" Height=\"18.9\" Text=\"Id" +
        "\" Font=\"Arial, 10pt, style=Bold\" Style=\"Header\"/>\r\n        <TextObject Name=\"Tex" +
        "t3\" Left=\"103.95\" Width=\"614.25\" Height=\"18.9\" Text=\"[sp_GetAuthorDetails.Id]\" F" +
        "ont=\"Arial, 10pt\" Style=\"Data\"/>\r\n        <TextObject Name=\"Text4\" Top=\"18.9\" Wi";
      reportString += "dth=\"103.95\" Height=\"18.9\" Text=\"AuthorName\" Font=\"Arial, 10pt, style=Bold\" Styl" +
        "e=\"Header\"/>\r\n        <TextObject Name=\"Text5\" Left=\"103.95\" Top=\"18.9\" Width=\"6" +
        "14.25\" Height=\"18.9\" Text=\"[sp_GetAuthorDetails.AuthorName]\" Font=\"Arial, 10pt\" " +
        "Style=\"Data\"/>\r\n        <TextObject Name=\"Text6\" Top=\"37.8\" Width=\"103.95\" Heigh" +
        "t=\"18.9\" Text=\"ISBN\" Font=\"Arial, 10pt, style=Bold\" Style=\"Header\"/>\r\n        <T" +
        "extObject Name=\"Text7\" Left=\"103.95\" Top=\"37.8\" Width=\"614.25\" Height=\"18.9\" Tex" +
        "t=\"[sp_GetAuthorDetails.ISBN]\" Font=\"Arial, 10pt\" Style=\"Data\"/>\r\n        <TextO" +
        "bject Name=\"Text8\" Top=\"56.7\" Width=\"103.95\" Height=\"18.9\" Text=\"Title\" Font=\"Ar" +
        "ial, 10pt, style=Bold\" Style=\"Header\"/>\r\n        <TextObject Name=\"Text9\" Left=\"" +
        "103.95\" Top=\"56.7\" Width=\"614.25\" Height=\"18.9\" Text=\"[sp_GetAuthorDetails.Title" +
        "]\" Font=\"Arial, 10pt\" Style=\"Data\"/>\r\n        <TextObject Name=\"Text10\" Top=\"75." +
        "6\" Width=\"103.95\" Height=\"18.9\" Text=\"Edition\" Font=\"Arial, 10pt, style=Bold\" St";
      reportString += "yle=\"Header\"/>\r\n        <TextObject Name=\"Text11\" Left=\"103.95\" Top=\"75.6\" Width" +
        "=\"614.25\" Height=\"18.9\" Text=\"[sp_GetAuthorDetails.Edition]\" Font=\"Arial, 10pt\" " +
        "Style=\"Data\"/>\r\n        <TextObject Name=\"Text12\" Top=\"94.5\" Width=\"103.95\" Heig" +
        "ht=\"18.9\" Text=\"PublishDate\" Font=\"Arial, 10pt, style=Bold\" Style=\"Header\"/>\r\n  " +
        "      <TextObject Name=\"Text13\" Left=\"103.95\" Top=\"94.5\" Width=\"614.25\" Height=\"" +
        "18.9\" Text=\"[sp_GetAuthorDetails.PublishDate]\" Font=\"Arial, 10pt\" Style=\"Data\"/>" +
        "\r\n        <TextObject Name=\"Text14\" Top=\"113.4\" Width=\"103.95\" Height=\"18.9\" Tex" +
        "t=\"Genre\" Font=\"Arial, 10pt, style=Bold\" Style=\"Header\"/>\r\n        <TextObject N" +
        "ame=\"Text15\" Left=\"103.95\" Top=\"113.4\" Width=\"614.25\" Height=\"18.9\" Text=\"[sp_Ge" +
        "tAuthorDetails.Genre]\" Font=\"Arial, 10pt\" Style=\"Data\"/>\r\n        <TextObject Na" +
        "me=\"Text16\" Top=\"132.3\" Width=\"103.95\" Height=\"18.9\" Text=\"Available\" Font=\"Aria" +
        "l, 10pt, style=Bold\" Style=\"Header\"/>\r\n        <TextObject Name=\"Text17\" Left=\"1";
      reportString += "03.95\" Top=\"132.3\" Width=\"614.25\" Height=\"18.9\" Text=\"[sp_GetAuthorDetails.Avail" +
        "able]\" Font=\"Arial, 10pt\" Style=\"Data\"/>\r\n      </DataBand>\r\n      <GroupFooterB" +
        "and Name=\"GroupFooter1\" Top=\"233.35\" Width=\"718.2\" Height=\"18.9\"/>\r\n    </GroupH" +
        "eaderBand>\r\n    <PageFooterBand Name=\"PageFooter1\" Top=\"257.58\" Width=\"718.2\" He" +
        "ight=\"18.9\">\r\n      <TextObject Name=\"Text19\" Width=\"718.2\" Height=\"18.9\" Dock=\"" +
        "Fill\" Text=\"[PageN]\" HorzAlign=\"Right\" Font=\"Arial, 10pt\" Style=\"Footer\"/>\r\n    " +
        "</PageFooterBand>\r\n  </ReportPage>\r\n</Report>\r\n";
      LoadFromString(reportString);
      InternalInit();
      
    }

    public AuthorDetailsReport()
    {
      InitializeComponent();
    }
  }
}
