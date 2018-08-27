
namespace FlomioSDK {
    public enum DeviceType : long
{
    kDeviceTypeDefault,
    kFlojackBzr,
    kFlojackMsr,
    kFloBleEmv,
    kFloBlePlus,
    kuGrokit,
}

public enum CommunicationStatus : long
{
    kScanning,
    kConnected,
    kDisconnected
};

public enum CardStatus : long
{
    kNotPresent,
    kPresent,
    kReadingData
};

public enum PowerOperation : long
{
    kAutoPollingControl,
    kBluetoothConnectionControl
};

public enum TransmitPower : long
{
    kVeryLowPower,
    kLowPower,
    kMediumPower,
    kHighPower
};

public enum TagDiscovery : long
{
    kReadUid,
    kReadData,
    kWriteData
};

public enum TagType : long
{
    kTagTypeDefault,
    kType2,
    kMifareClassic1k,
    kType4,
    kMifarePlus2kS //read data not supported
};


}
