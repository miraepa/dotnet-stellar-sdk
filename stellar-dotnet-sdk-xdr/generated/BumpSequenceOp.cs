// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct BumpSequenceOp
//  {
//      SequenceNumber bumpTo;
//  };

//  ===========================================================================
    public class BumpSequenceOp
    {
        public BumpSequenceOp()
        {
        }

        public SequenceNumber BumpTo { get; set; }

        public static void Encode(XdrDataOutputStream stream, BumpSequenceOp encodedBumpSequenceOp)
        {
            SequenceNumber.Encode(stream, encodedBumpSequenceOp.BumpTo);
        }

        public static BumpSequenceOp Decode(XdrDataInputStream stream)
        {
            BumpSequenceOp decodedBumpSequenceOp = new BumpSequenceOp();
            decodedBumpSequenceOp.BumpTo = SequenceNumber.Decode(stream);
            return decodedBumpSequenceOp;
        }
    }
}