
using System.Collections.Generic;
using System.Dynamic;

namespace Fin2020.PaymentModels.Nacha
{
    public class NachaHeader 
    {
        public FileHeaderRecordTypeCode RecordTypeCode { get; set; }
        public FileHeaderPriorityCode PriorityCode { get; set; }
        public FileHeaderImmidiateDestination ImmidiateDestination { get; set; }
        public FileHeaderImmidiateOrigin ImmidiateOrigin { get; set; }
        public FileHeaderFileCreationDate FileCreationDate { get; set; }
        public FileHeaderFileCreationTIme FileCreationTime { get; set; }
        public FileHeaderFileModifier FileIdModifier { get; set; }
        public FileHeaderRecordSize RecordSize { get; set; }
        public FileHeaderBlockingFactor BlockingFactor { get; set; }
        public FileHeaderFormatCode FormatCode { get; set; }
        public FileHeaderImmdiateDestinationName ImmidiateDestinationName { get; set; }
        public FileHeaderImmidiateOriginName ImmidiateOriginName { get; set; }
        public FileHeaderReferenceCode ReferenceCode { get; set; }
    }

    public class FileHeaderRecordTypeCode
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderPriorityCode
    {
        public static int Length = 2;
        public static int Position = 2;
        public static string Mandatory = "R";
        public string Value { get; set; }
    }

    public class FileHeaderImmidiateDestination
    {
        public static int Length = 10;
        public static int Position = 4;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderImmidiateOrigin
    {
        public static int Length = 10;
        public static int Position = 14;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderFileCreationDate
    {
        public static int Length = 6;
        public static int Position = 24;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderFileCreationTIme
    {
        public static int Length = 4;
        public static int Position = 30;
        public static string Mandatory = "O";
        public string Value { get; set; }
    }

    public class FileHeaderFileModifier
    {
        public static int Length = 1;
        public static int Position = 34;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderRecordSize
    {
        public static int Length = 3;
        public static int Position = 35;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderBlockingFactor
    {
        public static int Length = 2;
        public static int Position = 38;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderFormatCode
    {
        public static int Length = 1;
        public static int Position = 40;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class FileHeaderImmdiateDestinationName
    {
        public static int Length = 23;
        public static int Position = 41;
        public static string Mandatory = "O";
        public string Value { get; set; }
    }

    public class FileHeaderImmidiateOriginName
    {
        public static int Length = 23;
        public static int Position = 64;
        public static string Mandatory = "O";
        public string Value { get; set; }
    }

    public class FileHeaderReferenceCode
    {
        public static int Length = 8;
        public static int Position = 87;
        public static string Mandatory = "O";
        public string Value { get; set; }
    }

}
