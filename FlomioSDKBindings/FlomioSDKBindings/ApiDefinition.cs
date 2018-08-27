using System;
using AVFoundation;
using AudioToolbox;
using CoreBluetooth;
using CoreFoundation;
using CoreMedia;
using Foundation;

namespace FlomioSDK
{


    // @interface FmErrorManager : NSObject
    [BaseType(typeof(NSObject))]
    interface FmErrorManager
    {
        // +(BOOL)checkForSuccess:(NSString *)response;
        [Static]
        [Export("checkForSuccess:")]
        bool CheckForSuccess(string response);

        // +(NSError *)handleError:(NSString *)response;
        [Static]
        [Export("handleError:")]
        NSError HandleError(string response);

    }

    // @interface FmNdefRecord : NSObject
    [BaseType(typeof(NSObject))]
    interface FmNdefRecord
    {
        // @property (readonly, nonatomic) short tnf;
        [Export("tnf")]
        short Tnf { get; }

        // @property (readonly, nonatomic) NSData * type;
        [Export("type")]
        NSData Type { get; }

        // @property (readonly, nonatomic) NSData * theId;
        [Export("theId")]
        NSData TheId { get; }

        // @property (readonly, nonatomic) NSData * payload;
        [Export("payload")]
        NSData Payload { get; }

        // @property (readonly, nonatomic) NSString * typeString;
        [Export("typeString")]
        string TypeString { get; }

        // @property (readonly, nonatomic) NSString * theIdString;
        [Export("theIdString")]
        string TheIdString { get; }

        // @property (readonly, nonatomic) NSString * payloadString;
        [Export("payloadString")]
        string PayloadString { get; }

        // -(id)initWithTnf:(short)tnf andType:(NSData *)type andId:(NSData *)theId andPayload:(NSData *)payload;
        [Export("initWithTnf:andType:andId:andPayload:")]
        IntPtr Constructor(short tnf, NSData type, NSData theId, NSData payload);

        // -(id)initWithTnf:(short)tnf andType:(NSData *)type andId:(NSData *)theId andPayload:(NSData *)payload andFlags:(NSData *)flags;
        [Export("initWithTnf:andType:andId:andPayload:andFlags:")]
        IntPtr Constructor(short tnf, NSData type, NSData theId, NSData payload, NSData flags);

        // +(FmNdefRecord *)createURIWithString:(NSString *)uriString;
        [Static]
        [Export("createURIWithString:")]
        FmNdefRecord CreateURIWithString(string uriString);
    }

    // @interface FmNdefMessage : NSObject
    [BaseType(typeof(NSObject))]
    interface FmNdefMessage
    { }

    // @interface FmTag : NSObject
    [BaseType(typeof(NSObject))]
    interface FmTag
    {
        // @property (nonatomic, strong) NSString * atr;
        [Export("atr")]
        string Atr { get; set; }

        // @property (nonatomic, strong) NSString * uid;
        [Export("uid")]
        string Uid { get; set; }

        // @property (nonatomic) TagType type;
        [Export("type")]
        TagType Type { get; set; }

        // -(void)sendApdu:(NSString *)apdu success:(void (^)(NSString *))completionBlock;
        [Export("sendApdu:success:")]
        void SendApdu(string apdu, Action<NSString> completionBlock);

        // -(void)writeNdef:(FmNdefMessage *)ndef success:(void (^)(BOOL))completionBlock;
        [Export("writeNdef:success:")]
        void WriteNdef(FmNdefMessage ndef, Action<bool> completionBlock);

        // -(void)readNdef:(void (^)(FmNdefMessage *))completionBlock;
        [Export("readNdef:")]
        void ReadNdef(Action<FmNdefMessage> completionBlock);
    }

    // @protocol FmSessionManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface FmSessionManagerDelegate
    {
        // @optional -(void)didFindTag:(FmTag *)tag fromDevice:(NSString *)deviceUid;
        [Export("didFindTag:fromDevice:")]
        void DidFindTag(FmTag tag, string deviceUid);

        // @optional -(void)didReceiveReaderError:(NSError *)error;
        [Export("didReceiveReaderError:")]
        void DidReceiveReaderError(NSError error);

        // @optional -(void)didChangeCardStatus:(CardStatus)status fromDevice:(NSString *)device;
        [Export("didChangeCardStatus:fromDevice:")]
        void DidChangeCardStatus(CardStatus status, string device);

        // @optional -(void)didChangeStatus:(NSString *)deviceUid withConfiguration:(FmConfiguration *)configuration andBatteryLevel:(NSNumber *)batteryLevel andCommunicationStatus:(CommunicationStatus)communicationStatus withFirmwareRevision:(NSString *)firmwareRev withHardwareRevision:(NSString *)hardwareRev;
        [Export("didChangeStatus:withConfiguration:andBatteryLevel:andCommunicationStatus:withFirmwareRevision:withHardwareRevision:")]
        void DidChangeStatus(string deviceUid, FmConfiguration configuration, NSNumber batteryLevel, CommunicationStatus communicationStatus, string firmwareRev, string hardwareRev);

        // @optional -(void)didGetLicenseInfo:(NSString *)deviceUid withStatus:(BOOL)isRegistered;
        [Export("didGetLicenseInfo:withStatus:")]
        void DidGetLicenseInfo(string deviceUid, bool isRegistered);

        // @optional -(void)didMasterKeyUpdate:(BOOL)success withError:(NSError *)error;
        [Export("didMasterKeyUpdate:withError:")]
        void DidMasterKeyUpdate(bool success, NSError error);
    }

    // @interface FmConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface FmConfiguration
    {
        // @property (nonatomic) DeviceType deviceType;
        [Export("deviceType")]
        DeviceType DeviceType { get; set; }

        // @property (nonatomic) TagDiscovery tagDiscovery;
        [Export("tagDiscovery")]
        TagDiscovery TagDiscovery { get; set; }

        // @property (nonatomic, strong) NSNumber * scanPeriod;
        [Export("scanPeriod")]
        NSNumber ScanPeriod { get; set; }

        // @property (nonatomic, strong) NSNumber * scanSound;
        [Export("scanSound")]
        NSNumber ScanSound { get; set; }

        // @property (nonatomic) PowerOperation powerOperation;
        [Export("powerOperation")]
        PowerOperation PowerOperation { get; set; }

        // @property (nonatomic) TransmitPower transmitPower;
        [Export("transmitPower")]
        TransmitPower TransmitPower { get; set; }

        // @property (nonatomic, strong) NSNumber * allowMultiConnect;
        [Export("allowMultiConnect")]
        NSNumber AllowMultiConnect { get; set; }

        // @property (nonatomic, strong) NSString * specificDeviceUid;
        [Export("specificDeviceUid")]
        string SpecificDeviceUid { get; set; }

        // @property (nonatomic, strong) NSNumber * isCeMode;
        [Export("isCeMode")]
        NSNumber IsCeMode { get; set; }

        // @property (nonatomic, strong) NSArray * rfidTagsToFind;
        [Export("rfidTagsToFind")]
        NSObject[] RfidTagsToFind { get; set; }

        // -(void)setConfiguration:(FmConfiguration *)configurationDictionary;
        [Export("setConfiguration:")]
        void SetConfiguration(FmConfiguration configurationDictionary);
    }

    // @interface FmSessionManager : NSObject <FmSessionDelegate, FmAudioJackConnectionsManagerDelegate, FmBluetoothConnectionsManagerDelegate>
    [BaseType(typeof(NSObject))]
    interface FmSessionManager
    {
        // +(id)flomioSDK;
        [Static]
        [Export("flomioSDK")]
        NSObject FlomioSDK { get; }

        // -(id)initWithConfiguration:(FmConfiguration *)configuration;
        [Export("initWithConfiguration:")]
        IntPtr Constructor(FmConfiguration configuration);

        // -(void)startReaders;
        [Export("startReaders")]
        void StartReaders();

        // -(void)stopReaders;
        [Export("stopReaders")]
        void StopReaders();

        // -(void)sleepReaders;
        [Export("sleepReaders")]
        void SleepReaders();

        // -(void)startReader:(NSString *)deviceUid;
        [Export("startReader:")]
        void StartReader(string deviceUid);

        // -(void)stopReader:(NSString *)deviceUid;
        [Export("stopReader:")]
        void StopReader(string deviceUid);

        // -(void)sleepReader:(NSString *)deviceUid;
        [Export("sleepReader:")]
        void SleepReader(string deviceUid);

        // -(void)updateCeNdef:(FmNdefMessage *)ndef withDeviceUid:(NSString *)deviceUid;
        [Export("updateCeNdef:withDeviceUid:")]
        void UpdateCeNdef(FmNdefMessage ndef, string deviceUid);

        // -(void)writeRfidTag:(NSData *)data withOffset:(int)offset success:(void (^)(NSString *))completionBlock;
        [Export("writeRfidTag:withOffset:success:")]
        void WriteRfidTag(NSData data, int offset, Action<NSString> completionBlock);

        // -(void)readRfidTag:(int)offset success:(void (^)(NSString *))completionBlock;
        [Export("readRfidTag:success:")]
        void ReadRfidTag(int offset, Action<NSString> completionBlock);

        // -(void)setConfiguration:(FmConfiguration *)configuration ofDevice:(NSString *)deviceUid;
        [Export("setConfiguration:ofDevice:")]
        void SetConfiguration(FmConfiguration configuration, string deviceUid);

        // -(FmConfiguration *)getConfiguration:(NSString *)deviceUid;
        [Export("getConfiguration:")]
        FmConfiguration GetConfiguration(string deviceUid);

        // -(void)sendApdu:(NSString *)apdu toDevice:(NSString *)deviceUid success:(void (^)(NSString *))completionBlock;
        [Export("sendApdu:toDevice:success:")]
        void SendApdu(string apdu, string deviceUid, Action<NSString> completionBlock);

        [Wrap("WeakDelegate")]
        FmSessionManagerDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<FmSessionManagerDelegate> delegate;
        [NullAllowed, Export("delegate")]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) FmConfiguration * configuration;
        [Export("configuration")]
        FmConfiguration Configuration { get; set; }
    }


}
