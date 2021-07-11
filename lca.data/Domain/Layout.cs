using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Keyless]
    [Table("layout")]
    public partial class Layout
    {
        [Column("ID")]
        [StringLength(50)]
        public string Id { get; set; }
        [Column("EPDListName")]
        [StringLength(50)]
        public string EpdlistName { get; set; }
        [Column("EPDVersion")]
        [StringLength(50)]
        public string Epdversion { get; set; }
        [Column("EPDLanguage")]
        [StringLength(50)]
        public string Epdlanguage { get; set; }
        [Column("EPDSubTxt")]
        [StringLength(50)]
        public string EpdsubTxt { get; set; }
        [Column("EPDHeading")]
        [StringLength(50)]
        public string Epdheading { get; set; }
        [Column("EPDHeadingSub")]
        [StringLength(50)]
        public string EpdheadingSub { get; set; }
        [Column("EPDOwner")]
        [StringLength(50)]
        public string Epdowner { get; set; }
        [Column("EPDOwnerTxt")]
        [StringLength(50)]
        public string EpdownerTxt { get; set; }
        [Column("EPDOperator")]
        [StringLength(50)]
        public string Epdoperator { get; set; }
        [Column("EPDOperatorTxt")]
        [StringLength(50)]
        public string EpdoperatorTxt { get; set; }
        [Column("EPDPublisher")]
        [StringLength(50)]
        public string Epdpublisher { get; set; }
        [Column("EPDPublisherTxt")]
        [StringLength(50)]
        public string EpdpublisherTxt { get; set; }
        [Column("EPDDeclarationNo")]
        [StringLength(50)]
        public string EpddeclarationNo { get; set; }
        [Column("EPDPublishingNo")]
        [StringLength(50)]
        public string EpdpublishingNo { get; set; }
        [Column("EPDDECONo")]
        [StringLength(50)]
        public string Epddecono { get; set; }
        [Column("EPDApproved")]
        [StringLength(50)]
        public string Epdapproved { get; set; }
        [Column("EPDValid")]
        [StringLength(50)]
        public string Epdvalid { get; set; }
        [Column("EPDName")]
        [StringLength(50)]
        public string Epdname { get; set; }
        [Column("EPDLogo")]
        [StringLength(50)]
        public string Epdlogo { get; set; }
        [Column("EPDMainPicture")]
        [StringLength(50)]
        public string EpdmainPicture { get; set; }
        [Column("EPDGeneralHeading")]
        [StringLength(50)]
        public string EpdgeneralHeading { get; set; }
        [Column("EPDProducer")]
        [StringLength(50)]
        public string Epdproducer { get; set; }
        [Column("EPDProductionSite")]
        [StringLength(50)]
        public string EpdproductionSite { get; set; }
        [Column("EPDQualitySystem")]
        [StringLength(50)]
        public string EpdqualitySystem { get; set; }
        [Column("EPDPCR")]
        [StringLength(50)]
        public string Epdpcr { get; set; }
        [Column("EPDPCRTxt")]
        [StringLength(50)]
        public string Epdpcrtxt { get; set; }
        [Column("EPDCompanyNo")]
        [StringLength(50)]
        public string EpdcompanyNo { get; set; }
        [Column("EPDDeclaration")]
        [StringLength(50)]
        public string Epddeclaration { get; set; }
        [Column("EPDDeclarationTxt")]
        [StringLength(50)]
        public string EpddeclarationTxt { get; set; }
        [Column("EPDYear")]
        [StringLength(50)]
        public string Epdyear { get; set; }
        [Column("EPDUnit")]
        [StringLength(50)]
        public string Epdunit { get; set; }
        [Column("EPDUnitOption")]
        [StringLength(50)]
        public string EpdunitOption { get; set; }
        [Column("EPDUnitOptionTxt")]
        [StringLength(50)]
        public string EpdunitOptionTxt { get; set; }
        [Column("EPDCompare")]
        [StringLength(50)]
        public string Epdcompare { get; set; }
        [Column("EPDCompareTxt")]
        [StringLength(50)]
        public string EpdcompareTxt { get; set; }
        [Column("EPDStudy")]
        [StringLength(50)]
        public string Epdstudy { get; set; }
        [Column("EPDVerificatior")]
        [StringLength(50)]
        public string Epdverificatior { get; set; }
        [Column("EPDVerificatiorTxt")]
        [StringLength(50)]
        public string EpdverificatiorTxt { get; set; }
        [Column("EPDIntern")]
        [StringLength(50)]
        public string Epdintern { get; set; }
        [Column("EPDExtern")]
        [StringLength(50)]
        public string Epdextern { get; set; }
        [Column("EPD3Party")]
        [StringLength(50)]
        public string Epd3party { get; set; }
        [Column("EPD3PartyName")]
        [StringLength(50)]
        public string Epd3partyName { get; set; }
        [Column("EPD3PartySubTxt")]
        [StringLength(50)]
        public string Epd3partySubTxt { get; set; }
        [Column("EPDApprovedBy")]
        [StringLength(50)]
        public string EpdapprovedBy { get; set; }
        [Column("EPDApprovedByTxt")]
        [StringLength(50)]
        public string EpdapprovedByTxt { get; set; }
        [Column("EPDProductHeading")]
        [StringLength(50)]
        public string EpdproductHeading { get; set; }
        [Column("EPDProductDescrition")]
        [StringLength(50)]
        public string EpdproductDescrition { get; set; }
        [Column("EPDProductDescritionTxt")]
        [StringLength(50)]
        public string EpdproductDescritionTxt { get; set; }
        [Column("EPDProductSpesification")]
        [StringLength(50)]
        public string EpdproductSpesification { get; set; }
        [Column("EPDProductSpesificationTxt")]
        [StringLength(50)]
        public string EpdproductSpesificationTxt { get; set; }
        [Column("EPDProductSpesificationTable")]
        [StringLength(50)]
        public string EpdproductSpesificationTable { get; set; }
        [Column("EPDProductTechical")]
        [StringLength(50)]
        public string EpdproductTechical { get; set; }
        [Column("EPDProductTechicalTxt")]
        [StringLength(50)]
        public string EpdproductTechicalTxt { get; set; }
        [Column("EPDProductMarket")]
        [StringLength(50)]
        public string EpdproductMarket { get; set; }
        [Column("EPDProductMarketTxt")]
        [StringLength(50)]
        public string EpdproductMarketTxt { get; set; }
        [Column("EPDProductLife")]
        [StringLength(50)]
        public string EpdproductLife { get; set; }
        [Column("EPDProductLifeTxt")]
        [StringLength(50)]
        public string EpdproductLifeTxt { get; set; }
        [Column("EPDLCAHeading")]
        [StringLength(50)]
        public string Epdlcaheading { get; set; }
        [Column("EPDDeclarationTxt2")]
        [StringLength(50)]
        public string EpddeclarationTxt2 { get; set; }
        [Column("EPDSystem")]
        [StringLength(50)]
        public string Epdsystem { get; set; }
        [Column("EPDSystemTxt")]
        [StringLength(50)]
        public string EpdsystemTxt { get; set; }
        [Column("EPDSystemTxt2")]
        [StringLength(50)]
        public string EpdsystemTxt2 { get; set; }
        [Column("EPDDataQuality")]
        [StringLength(50)]
        public string EpddataQuality { get; set; }
        [Column("EPDDataQualityTxt")]
        [StringLength(50)]
        public string EpddataQualityTxt { get; set; }
        [Column("EPDAllocation")]
        [StringLength(50)]
        public string Epdallocation { get; set; }
        [Column("EPDAllocationTxt")]
        [StringLength(50)]
        public string EpdallocationTxt { get; set; }
        [Column("EPDCutoff")]
        [StringLength(50)]
        public string Epdcutoff { get; set; }
        [Column("EPDCutoffTxt")]
        [StringLength(50)]
        public string EpdcutoffTxt { get; set; }
        [Column("EPDLCASenariosHeading")]
        [StringLength(50)]
        public string EpdlcasenariosHeading { get; set; }
        [Column("EPDLCASenariosHeadingTxt")]
        [StringLength(50)]
        public string EpdlcasenariosHeadingTxt { get; set; }
        [Column("EPDA4Heading")]
        [StringLength(50)]
        public string Epda4heading { get; set; }
        [Column("EPDA5Heading")]
        [StringLength(50)]
        public string Epda5heading { get; set; }
        [Column("EPDB1Heading")]
        [StringLength(50)]
        public string Epdb1heading { get; set; }
        [Column("EPDB2B3Heading")]
        [StringLength(50)]
        public string Epdb2b3heading { get; set; }
        [Column("EPDB4B5Heading")]
        [StringLength(50)]
        public string Epdb4b5heading { get; set; }
        [Column("EPDB6B7Heading")]
        [StringLength(50)]
        public string Epdb6b7heading { get; set; }
        [Column("EPDC1C3C4Heading")]
        [StringLength(50)]
        public string Epdc1c3c4heading { get; set; }
        [Column("EPDC2Heading")]
        [StringLength(50)]
        public string Epdc2heading { get; set; }
        [Column("EPDC2HeadingTxt")]
        [StringLength(50)]
        public string Epdc2headingTxt { get; set; }
        [Column("EPDD1Heading")]
        [StringLength(50)]
        public string Epdd1heading { get; set; }
        [Column("EPDLCAResultHeading")]
        [StringLength(50)]
        public string EpdlcaresultHeading { get; set; }
        [Column("EPDLCAResultTxt")]
        [StringLength(50)]
        public string EpdlcaresultTxt { get; set; }
        [Column("EPDSystemHeading")]
        [StringLength(50)]
        public string EpdsystemHeading { get; set; }
        [Column("EPDSystemSubTxt")]
        [StringLength(50)]
        public string EpdsystemSubTxt { get; set; }
        [Column("EPDEnviromentHeading")]
        [StringLength(50)]
        public string EpdenviromentHeading { get; set; }
        [Column("EPDEnviromentSubTxt")]
        [StringLength(50)]
        public string EpdenviromentSubTxt { get; set; }
        [Column("EPDResressourcesHeading")]
        [StringLength(50)]
        public string EpdresressourcesHeading { get; set; }
        [Column("EPDressourcesSubTxt")]
        [StringLength(50)]
        public string EpdressourcesSubTxt { get; set; }
        [Column("EPDEndOfLifeWasteHeading")]
        [StringLength(50)]
        public string EpdendOfLifeWasteHeading { get; set; }
        [Column("EPDEndOfLifeWasteSubTxt")]
        [StringLength(50)]
        public string EpdendOfLifeWasteSubTxt { get; set; }
        [Column("EPDEndOfLifeFactorHeading")]
        [StringLength(50)]
        public string EpdendOfLifeFactorHeading { get; set; }
        [Column("EPDEndOfLifeFactorSubTxt")]
        [StringLength(50)]
        public string EpdendOfLifeFactorSubTxt { get; set; }
        [Column("EPDNOAddHeading")]
        [StringLength(50)]
        public string EpdnoaddHeading { get; set; }
        [Column("UserID")]
        [StringLength(50)]
        public string UserId { get; set; }
        [StringLength(50)]
        public string Date { get; set; }
        [StringLength(50)]
        public string Comments { get; set; }
        [Column("EPDDescription")]
        [StringLength(50)]
        public string Epddescription { get; set; }
        [Column("EPDPicture1")]
        [StringLength(50)]
        public string Epdpicture1 { get; set; }
        [Column("EPDPicture2")]
        [StringLength(50)]
        public string Epdpicture2 { get; set; }
        [Column("EPDNOAddTXT")]
        [StringLength(50)]
        public string EpdnoaddTxt { get; set; }
        [Column("EPDApprovedName")]
        [StringLength(50)]
        public string EpdapprovedName { get; set; }
        [Column("EPDNOAddDanger1")]
        [StringLength(50)]
        public string EpdnoaddDanger1 { get; set; }
        [Column("EPDNOAddDanger2")]
        [StringLength(50)]
        public string EpdnoaddDanger2 { get; set; }
        [Column("EPDNOAddDanger3")]
        [StringLength(50)]
        public string EpdnoaddDanger3 { get; set; }
        [Column("EPDNOAddDanger4")]
        [StringLength(50)]
        public string EpdnoaddDanger4 { get; set; }
        [Column("EPDBiblHead")]
        [StringLength(50)]
        public string EpdbiblHead { get; set; }
        [Column("EPDBiblTxt")]
        [StringLength(50)]
        public string EpdbiblTxt { get; set; }
        [Column("A1Txt")]
        [StringLength(50)]
        public string A1txt { get; set; }
        [Column("A2Txt")]
        [StringLength(50)]
        public string A2txt { get; set; }
        [Column("A3Txt")]
        [StringLength(50)]
        public string A3txt { get; set; }
        [Column("A4Txt")]
        [StringLength(50)]
        public string A4txt { get; set; }
        [Column("A5Txt")]
        [StringLength(50)]
        public string A5txt { get; set; }
        [Column("B1Txt")]
        [StringLength(50)]
        public string B1txt { get; set; }
        [Column("B2Txt")]
        [StringLength(50)]
        public string B2txt { get; set; }
        [Column("B3Txt")]
        [StringLength(50)]
        public string B3txt { get; set; }
        [Column("B4Txt")]
        [StringLength(50)]
        public string B4txt { get; set; }
        [Column("B5Txt")]
        [StringLength(50)]
        public string B5txt { get; set; }
        [Column("B6Txt")]
        [StringLength(50)]
        public string B6txt { get; set; }
        [Column("B7Txt")]
        [StringLength(50)]
        public string B7txt { get; set; }
        [Column("C1Txt")]
        [StringLength(50)]
        public string C1txt { get; set; }
        [Column("C2Txt")]
        [StringLength(50)]
        public string C2txt { get; set; }
        [Column("C3Txt")]
        [StringLength(50)]
        public string C3txt { get; set; }
        [Column("C4Txt")]
        [StringLength(50)]
        public string C4txt { get; set; }
        [Column("D1Txt")]
        [StringLength(50)]
        public string D1txt { get; set; }
        [Column("EPDNOAddsubhead1")]
        [StringLength(50)]
        public string Epdnoaddsubhead1 { get; set; }
        [Column("EPDNOAddsubhead1Txt")]
        [StringLength(50)]
        public string Epdnoaddsubhead1Txt { get; set; }
        [Column("EPDNOAddsubhead2")]
        [StringLength(50)]
        public string Epdnoaddsubhead2 { get; set; }
        [Column("EPDNOAddsubhead2Txt")]
        [StringLength(50)]
        public string Epdnoaddsubhead2Txt { get; set; }
        [Column("EPDNOAddsubhead3")]
        [StringLength(50)]
        public string Epdnoaddsubhead3 { get; set; }
        [Column("EPDNOAddsubhead3Txt")]
        [StringLength(50)]
        public string Epdnoaddsubhead3Txt { get; set; }
        [Column("EPDDoneby")]
        [StringLength(50)]
        public string Epddoneby { get; set; }
        [Column("EPDDonebyTxt")]
        [StringLength(50)]
        public string EpddonebyTxt { get; set; }
        [Column("EPDDonebyReg")]
        [StringLength(50)]
        public string EpddonebyReg { get; set; }
        [Column("EPDDonebyCon")]
        [StringLength(50)]
        public string EpddonebyCon { get; set; }
    }
}
