
using System.Collections.Generic;
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class ReportList
{

    private List<ReportListReportName> reportNameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ReportName")]
    public List<ReportListReportName> ReportName
    {
        get
        {
            return this.reportNameField;
        }
        set
        {
            this.reportNameField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ReportListReportName
{

    private List<ReportListReportNameUserDetails> userDetailsField;

    private string campaignNameField;

    private string searchStringField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("UserDetails")]
    public List<ReportListReportNameUserDetails> UserDetails
    {
        get
        {
            return this.userDetailsField;
        }
        set
        {
            this.userDetailsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string campaignName
    {
        get
        {
            return this.campaignNameField;
        }
        set
        {
            this.campaignNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string searchString
    {
        get
        {
            return this.searchStringField;
        }
        set
        {
            this.searchStringField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ReportListReportNameUserDetails
{

    private string userhandleField;

    private string timestampField;

    private string messageField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string userhandle
    {
        get
        {
            return this.userhandleField;
        }
        set
        {
            this.userhandleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string timestamp
    {
        get
        {
            return this.timestampField;
        }
        set
        {
            this.timestampField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Message
    {
        get
        {
            return this.messageField;
        }
        set
        {
            this.messageField = value;
        }
    }
}

