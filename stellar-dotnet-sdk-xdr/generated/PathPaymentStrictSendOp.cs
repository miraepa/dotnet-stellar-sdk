// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace stellar_dotnet_sdk.xdr
{
// === xdr source ============================================================

//  struct PathPaymentStrictSendOp
//  {
//      Asset sendAsset;  // asset we pay with
//      int64 sendAmount; // amount of sendAsset to send (excluding fees)
//  
//      AccountID destination; // recipient of the payment
//      Asset destAsset;       // what they end up with
//      int64 destMin;         // the minimum amount of dest asset to
//                             // be received
//                             // The operation will fail if it can't be met
//  
//      Asset path<5>; // additional hops it must go through to get there
//  };

//  ===========================================================================
    public class PathPaymentStrictSendOp
    {
        public PathPaymentStrictSendOp()
        {
        }

        public Asset SendAsset { get; set; }
        public Int64 SendAmount { get; set; }
        public AccountID Destination { get; set; }
        public Asset DestAsset { get; set; }
        public Int64 DestMin { get; set; }
        public Asset[] Path { get; set; }

        public static void Encode(XdrDataOutputStream stream, PathPaymentStrictSendOp encodedPathPaymentStrictSendOp)
        {
            Asset.Encode(stream, encodedPathPaymentStrictSendOp.SendAsset);
            Int64.Encode(stream, encodedPathPaymentStrictSendOp.SendAmount);
            AccountID.Encode(stream, encodedPathPaymentStrictSendOp.Destination);
            Asset.Encode(stream, encodedPathPaymentStrictSendOp.DestAsset);
            Int64.Encode(stream, encodedPathPaymentStrictSendOp.DestMin);
            int pathsize = encodedPathPaymentStrictSendOp.Path.Length;
            stream.WriteInt(pathsize);
            for (int i = 0; i < pathsize; i++)
            {
                Asset.Encode(stream, encodedPathPaymentStrictSendOp.Path[i]);
            }
        }

        public static PathPaymentStrictSendOp Decode(XdrDataInputStream stream)
        {
            PathPaymentStrictSendOp decodedPathPaymentStrictSendOp = new PathPaymentStrictSendOp();
            decodedPathPaymentStrictSendOp.SendAsset = Asset.Decode(stream);
            decodedPathPaymentStrictSendOp.SendAmount = Int64.Decode(stream);
            decodedPathPaymentStrictSendOp.Destination = AccountID.Decode(stream);
            decodedPathPaymentStrictSendOp.DestAsset = Asset.Decode(stream);
            decodedPathPaymentStrictSendOp.DestMin = Int64.Decode(stream);
            int pathsize = stream.ReadInt();
            decodedPathPaymentStrictSendOp.Path = new Asset[pathsize];
            for (int i = 0; i < pathsize; i++)
            {
                decodedPathPaymentStrictSendOp.Path[i] = Asset.Decode(stream);
            }

            return decodedPathPaymentStrictSendOp;
        }
    }
}