using System;
using Earthworm;

public class InsideNode : MappableFeature
{
    [MappedField("DOCID")]
    public virtual int? DOCID { get; set; }

    [MappedField("Type", 100)]
    public virtual string Type { get; set; }

    [MappedField("Subtype", 30)]
    public virtual string Subtype { get; set; }

    [MappedField("RelatedFCName", 50)]
    public virtual string RelatedFCName { get; set; }

    [MappedField("RelatedFOID")]
    public virtual int? RelatedFOID { get; set; }

    [MappedField("XGeo")]
    public virtual double? XGeo { get; set; }

    [MappedField("YGeo")]
    public virtual double? YGeo { get; set; }

    [MappedField("NAME", 100)]
    public virtual string NAME { get; set; }

    [MappedField("INFO1", 100)]
    public virtual string INFO1 { get; set; }

    [MappedField("INFO2", 100)]
    public virtual string INFO2 { get; set; }

    [MappedField("INFO3", 100)]
    public virtual string INFO3 { get; set; }
}