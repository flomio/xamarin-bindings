using System;
using UIKit;
using Foundation;
using FlomioSDK;

namespace FlomioExampleApp
{
    public partial class ViewController : UIViewController

    {

        FmSessionManager sessionManager;

        protected ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var configuration = new FmConfiguration
            {
                DeviceType = DeviceType.kFloBlePlus
            };

            sessionManager = new FmSessionManager(configuration); 
            sessionManager.WeakDelegate = this;
        }

        // -(void)didFindTag:(FmTag *)tag fromDevice:(NSString *)deviceUid;
        [Export("didFindTag:fromDevice:")]
        public void DidFindTag(FmTag tag, string deviceUid)
        {
           
        }

        // -(void)didReceiveReaderError:(NSError *)error;
        [Export("didReceiveReaderError:")]
        public void DidReceiveReaderError(NSError error)
        {

        }

        // -(void)didChangeCardStatus:(CardStatus)status fromDevice:(NSString *)device;
        [Export("didChangeCardStatus:fromDevice:")]
        public void DidChangeCardStatus(CardStatus status, string device)
        {

        }

        // -(void)didChangeStatus:(NSString *)deviceUid withConfiguration:(FmConfiguration *)configuration andBatteryLevel:(NSNumber *)batteryLevel andCommunicationStatus:(CommunicationStatus)communicationStatus withFirmwareRevision:(NSString *)firmwareRev withHardwareRevision:(NSString *)hardwareRev;
        [Export("didChangeStatus:withConfiguration:andBatteryLevel:andCommunicationStatus:withFirmwareRevision:withHardwareRevision:")]
        public void DidChangeStatus(string deviceUid, FmConfiguration configuration, NSNumber batteryLevel, CommunicationStatus communicationStatus, string firmwareRev, string hardwareRev)
        {

        }

        // -(void)didGetLicenseInfo:(NSString *)deviceUid withStatus:(BOOL)isRegistered;
        [Export("didGetLicenseInfo:withStatus:")]
        public void DidGetLicenseInfo(string deviceUid, bool isRegistered)
        {

        }

    }
}
