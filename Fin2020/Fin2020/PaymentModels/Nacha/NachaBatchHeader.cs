using System;
using System.Collections.Generic;
using System.Text;

namespace Fin2020.PaymentModels.Nacha
{
    public class NachaBatchHeader
    {
        public BatchHeaderRecordTypeCode RecordTypeCode { get; set; }
        public BatchHeaderServiceClassCode ServiceClassCode { get; set; }
        public BatchHeaderCompanyName CompanyName { get; set; }
        public BatchHeaderCoDisData CoDescriptiveData { get; set; }
        public BatchHeaderCompanyId CompanyId { get; set; }
        public BatchHeaderSEC SEC { get; set; }
        public BatchHeaderEntryDescription EntryDescription { get; set; }
        public BatchHeaderCoDescriptiveDate CoDescriptiveDate { get; set; }
        public BatchHeaderEffectiveEntryDate EffectiveEntryDate { get; set; }
        public BatchHeaderSettlementDate SettlementDate { get; set; }
        public BatchHeaderOriginatorStatusCode OriginatorStatusCode { get; set; }
        public BatchHeaderODFI_ID ODFI_ID { get; set; }
        public BatchHeaderBatchNumber BatchNumber { get; set; }
    }

    public class BatchHeaderRecordTypeCode
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderServiceClassCode
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderCompanyName
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderCoDisData
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderCompanyId
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderSEC
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderEntryDescription
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderCoDescriptiveDate
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderEffectiveEntryDate
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderSettlementDate
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderOriginatorStatusCode
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderODFI_ID
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }

    public class BatchHeaderBatchNumber
    {
        public static int Length = 1;
        public static int Position = 1;
        public static string Mandatory = "M";
        public string Value { get; set; }
    }
}
