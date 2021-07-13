using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LCA.Data.Domain
{
    [Table("EPDLayout")]
    public partial class Epdlayout
    {
        [Key]
        [Column("ID")]
        public int Id { get; set; }
        [Column("EPDListName")]
        [StringLength(1000)]
        public string EpdlistName { get; set; }
        [Column("EPDVersion")]
        [StringLength(50)]
        public string Epdversion { get; set; }
        [Column("EPDLanguage")]
        [StringLength(50)]
        public string Epdlanguage { get; set; }
        [Column("EPDSubTxt")]
        [StringLength(150)]
        public string EpdsubTxt { get; set; }
        [Column("EPDHeading")]
        [StringLength(1000)]
        public string Epdheading { get; set; }
        [Column("EPDHeadingSub")]
        [StringLength(1000)]
        public string EpdheadingSub { get; set; }
        [Column("EPDOwner")]
        [StringLength(150)]
        public string Epdowner { get; set; }
        [Column("EPDOwnerTxt")]
        [StringLength(150)]
        public string EpdownerTxt { get; set; }
        [Column("EPDOperator")]
        [StringLength(150)]
        public string Epdoperator { get; set; }
        [Column("EPDOperatorTxt")]
        [StringLength(150)]
        public string EpdoperatorTxt { get; set; }
        [Column("EPDPublisher")]
        [StringLength(150)]
        public string Epdpublisher { get; set; }
        [Column("EPDPublisherTxt")]
        [StringLength(150)]
        public string EpdpublisherTxt { get; set; }
        [Column("EPDDeclarationNo")]
        [StringLength(150)]
        public string EpddeclarationNo { get; set; }
        [Column("EPDPublishingNo")]
        [StringLength(150)]
        public string EpdpublishingNo { get; set; }
        [Column("EPDDECONo")]
        [StringLength(150)]
        public string Epddecono { get; set; }
        [Column("EPDApproved")]
        [StringLength(150)]
        public string Epdapproved { get; set; }
        [Column("EPDValid")]
        [StringLength(150)]
        public string Epdvalid { get; set; }
        [Column("EPDName")]
        [StringLength(150)]
        public string Epdname { get; set; }
        [Column("EPDLogo")]
        [StringLength(150)]
        public string Epdlogo { get; set; }
        [Column("EPDMainPicture")]
        [StringLength(150)]
        public string EpdmainPicture { get; set; }
        [Column("EPDGeneralHeading")]
        [StringLength(150)]
        public string EpdgeneralHeading { get; set; }
        [Column("EPDProducer")]
        [StringLength(150)]
        public string Epdproducer { get; set; }
        [Column("EPDProductionSite")]
        [StringLength(150)]
        public string EpdproductionSite { get; set; }
        [Column("EPDQualitySystem")]
        [StringLength(150)]
        public string EpdqualitySystem { get; set; }
        [Column("EPDPCR")]
        [StringLength(150)]
        public string Epdpcr { get; set; }
        [Column("EPDPCRTxt")]
        [StringLength(150)]
        public string Epdpcrtxt { get; set; }
        [Column("EPDCompanyNo")]
        [StringLength(150)]
        public string EpdcompanyNo { get; set; }
        [Column("EPDDeclaration")]
        [StringLength(150)]
        public string Epddeclaration { get; set; }
        [Column("EPDDeclarationTxt")]
        [StringLength(500)]
        public string EpddeclarationTxt { get; set; }
        [Column("EPDYear")]
        [StringLength(150)]
        public string Epdyear { get; set; }
        [Column("EPDUnit")]
        [StringLength(150)]
        public string Epdunit { get; set; }
        [Column("EPDUnitOption")]
        [StringLength(150)]
        public string EpdunitOption { get; set; }
        [Column("EPDUnitOptionTxt")]
        [StringLength(500)]
        public string EpdunitOptionTxt { get; set; }
        [Column("EPDCompare")]
        [StringLength(150)]
        public string Epdcompare { get; set; }
        [Column("EPDCompareTxt")]
        [StringLength(500)]
        public string EpdcompareTxt { get; set; }
        [Column("EPDStudy")]
        [StringLength(150)]
        public string Epdstudy { get; set; }
        [Column("EPDVerificatior")]
        [StringLength(150)]
        public string Epdverificatior { get; set; }
        [Column("EPDVerificatiorTxt")]
        [StringLength(200)]
        public string EpdverificatiorTxt { get; set; }
        [Column("EPDIntern")]
        [StringLength(150)]
        public string Epdintern { get; set; }
        [Column("EPDExtern")]
        [StringLength(150)]
        public string Epdextern { get; set; }
        [Column("EPD3Party")]
        [StringLength(150)]
        public string Epd3party { get; set; }
        [Column("EPD3PartyName")]
        [StringLength(150)]
        public string Epd3partyName { get; set; }
        [Column("EPD3PartySubTxt")]
        [StringLength(150)]
        public string Epd3partySubTxt { get; set; }
        [Column("EPDApprovedBy")]
        [StringLength(150)]
        public string EpdapprovedBy { get; set; }
        [Column("EPDApprovedByTxt")]
        [StringLength(150)]
        public string EpdapprovedByTxt { get; set; }
        [Column("EPDProductHeading")]
        [StringLength(150)]
        public string EpdproductHeading { get; set; }
        [Column("EPDProductDescrition")]
        [StringLength(150)]
        public string EpdproductDescrition { get; set; }
        [Column("EPDProductDescritionTxt")]
        [StringLength(500)]
        public string EpdproductDescritionTxt { get; set; }
        [Column("EPDProductSpesification")]
        [StringLength(150)]
        public string EpdproductSpesification { get; set; }
        [Column("EPDProductSpesificationTxt")]
        [StringLength(500)]
        public string EpdproductSpesificationTxt { get; set; }
        [Column("EPDProductSpesificationTable")]
        [StringLength(150)]
        public string EpdproductSpesificationTable { get; set; }
        [Column("EPDProductTechical")]
        [StringLength(150)]
        public string EpdproductTechical { get; set; }
        [Column("EPDProductTechicalTxt")]
        [StringLength(500)]
        public string EpdproductTechicalTxt { get; set; }
        [Column("EPDProductMarket")]
        [StringLength(150)]
        public string EpdproductMarket { get; set; }
        [Column("EPDProductMarketTxt")]
        [StringLength(500)]
        public string EpdproductMarketTxt { get; set; }
        [Column("EPDProductLife")]
        [StringLength(150)]
        public string EpdproductLife { get; set; }
        [Column("EPDProductLifeTxt")]
        [StringLength(150)]
        public string EpdproductLifeTxt { get; set; }
        [Column("EPDLCAHeading")]
        [StringLength(150)]
        public string Epdlcaheading { get; set; }
        [Column("EPDDeclarationTxt2")]
        [StringLength(500)]
        public string EpddeclarationTxt2 { get; set; }
        [Column("EPDSystem")]
        [StringLength(150)]
        public string Epdsystem { get; set; }
        [Column("EPDSystemTxt")]
        [StringLength(500)]
        public string EpdsystemTxt { get; set; }
        [Column("EPDSystemTxt2")]
        [StringLength(500)]
        public string EpdsystemTxt2 { get; set; }
        [Column("EPDDataQuality")]
        [StringLength(150)]
        public string EpddataQuality { get; set; }
        [Column("EPDDataQualityTxt")]
        [StringLength(500)]
        public string EpddataQualityTxt { get; set; }
        [Column("EPDAllocation")]
        [StringLength(150)]
        public string Epdallocation { get; set; }
        [Column("EPDAllocationTxt")]
        [StringLength(1000)]
        public string EpdallocationTxt { get; set; }
        [Column("EPDCutoff")]
        [StringLength(150)]
        public string Epdcutoff { get; set; }
        [Column("EPDCutoffTxt")]
        [StringLength(500)]
        public string EpdcutoffTxt { get; set; }
        [Column("EPDLCASenariosHeading")]
        [StringLength(150)]
        public string EpdlcasenariosHeading { get; set; }
        [Column("EPDLCASenariosHeadingTxt")]
        [StringLength(500)]
        public string EpdlcasenariosHeadingTxt { get; set; }
        [Column("EPDA4Heading")]
        [StringLength(150)]
        public string Epda4heading { get; set; }
        [Column("EPDA5Heading")]
        [StringLength(150)]
        public string Epda5heading { get; set; }
        [Column("EPDB1Heading")]
        [StringLength(150)]
        public string Epdb1heading { get; set; }
        [Column("EPDB2B3Heading")]
        [StringLength(150)]
        public string Epdb2b3heading { get; set; }
        [Column("EPDB4B5Heading")]
        [StringLength(150)]
        public string Epdb4b5heading { get; set; }
        [Column("EPDB6B7Heading")]
        [StringLength(150)]
        public string Epdb6b7heading { get; set; }
        [Column("EPDC1C3C4Heading")]
        [StringLength(150)]
        public string Epdc1c3c4heading { get; set; }
        [Column("EPDC2Heading")]
        [StringLength(150)]
        public string Epdc2heading { get; set; }
        [Column("EPDC2HeadingTxt")]
        [StringLength(500)]
        public string Epdc2headingTxt { get; set; }
        [Column("EPDD1Heading")]
        [StringLength(150)]
        public string Epdd1heading { get; set; }
        [Column("EPDLCAResultHeading")]
        [StringLength(150)]
        public string EpdlcaresultHeading { get; set; }
        [Column("EPDLCAResultTxt")]
        [StringLength(500)]
        public string EpdlcaresultTxt { get; set; }
        [Column("EPDSystemHeading")]
        [StringLength(150)]
        public string EpdsystemHeading { get; set; }
        [Column("EPDSystemSubTxt")]
        [StringLength(500)]
        public string EpdsystemSubTxt { get; set; }
        [Column("EPDEnviromentHeading")]
        [StringLength(150)]
        public string EpdenviromentHeading { get; set; }
        [Column("EPDEnviromentSubTxt")]
        [StringLength(500)]
        public string EpdenviromentSubTxt { get; set; }
        [Column("EPDResressourcesHeading")]
        [StringLength(600)]
        public string EpdresressourcesHeading { get; set; }
        [Column("EPDressourcesSubTxt")]
        [StringLength(500)]
        public string EpdressourcesSubTxt { get; set; }
        [Column("EPDEndOfLifeWasteHeading")]
        [StringLength(150)]
        public string EpdendOfLifeWasteHeading { get; set; }
        [Column("EPDEndOfLifeWasteSubTxt")]
        [StringLength(500)]
        public string EpdendOfLifeWasteSubTxt { get; set; }
        [Column("EPDEndOfLifeFactorHeading")]
        [StringLength(150)]
        public string EpdendOfLifeFactorHeading { get; set; }
        [Column("EPDEndOfLifeFactorSubTxt")]
        [StringLength(500)]
        public string EpdendOfLifeFactorSubTxt { get; set; }
        [Column("EPDNOAddHeading")]
        [StringLength(150)]
        public string EpdnoaddHeading { get; set; }
        [Column("UserID")]
        public long? UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
        [StringLength(5000)]
        public string Comments { get; set; }
        [Column("EPDDescription")]
        [StringLength(500)]
        public string Epddescription { get; set; }
        [Column("EPDPicture1")]
        [StringLength(150)]
        public string Epdpicture1 { get; set; }
        [Column("EPDPicture2")]
        [StringLength(150)]
        public string Epdpicture2 { get; set; }
        [Column("EPDNOAddTXT")]
        [StringLength(8000)]
        public string EpdnoaddTxt { get; set; }
        [Column("EPDApprovedName")]
        [StringLength(150)]
        public string EpdapprovedName { get; set; }
        [Column("EPDNOAddDanger1")]
        [StringLength(500)]
        public string EpdnoaddDanger1 { get; set; }
        [Column("EPDNOAddDanger2")]
        [StringLength(500)]
        public string EpdnoaddDanger2 { get; set; }
        [Column("EPDNOAddDanger3")]
        [StringLength(500)]
        public string EpdnoaddDanger3 { get; set; }
        [Column("EPDNOAddDanger4")]
        [StringLength(500)]
        public string EpdnoaddDanger4 { get; set; }
        [Column("EPDBiblHead")]
        [StringLength(150)]
        public string EpdbiblHead { get; set; }
        [Column("EPDBiblTxt")]
        [StringLength(2000)]
        public string EpdbiblTxt { get; set; }
        [Column("A1Txt")]
        [StringLength(150)]
        public string A1txt { get; set; }
        [Column("A2Txt")]
        [StringLength(150)]
        public string A2txt { get; set; }
        [Column("A3Txt")]
        [StringLength(150)]
        public string A3txt { get; set; }
        [Column("A4Txt")]
        [StringLength(150)]
        public string A4txt { get; set; }
        [Column("A5Txt")]
        [StringLength(150)]
        public string A5txt { get; set; }
        [Column("B1Txt")]
        [StringLength(150)]
        public string B1txt { get; set; }
        [Column("B2Txt")]
        [StringLength(150)]
        public string B2txt { get; set; }
        [Column("B3Txt")]
        [StringLength(150)]
        public string B3txt { get; set; }
        [Column("B4Txt")]
        [StringLength(150)]
        public string B4txt { get; set; }
        [Column("B5Txt")]
        [StringLength(150)]
        public string B5txt { get; set; }
        [Column("B6Txt")]
        [StringLength(150)]
        public string B6txt { get; set; }
        [Column("B7Txt")]
        [StringLength(150)]
        public string B7txt { get; set; }
        [Column("C1Txt")]
        [StringLength(150)]
        public string C1txt { get; set; }
        [Column("C2Txt")]
        [StringLength(150)]
        public string C2txt { get; set; }
        [Column("C3Txt")]
        [StringLength(150)]
        public string C3txt { get; set; }
        [Column("C4Txt")]
        [StringLength(150)]
        public string C4txt { get; set; }
        [Column("D1Txt")]
        [StringLength(150)]
        public string D1txt { get; set; }
        [Column("EPDNOAddsubhead1")]
        [StringLength(150)]
        public string Epdnoaddsubhead1 { get; set; }
        [Column("EPDNOAddsubhead1Txt")]
        [StringLength(500)]
        public string Epdnoaddsubhead1Txt { get; set; }
        [Column("EPDNOAddsubhead2")]
        [StringLength(150)]
        public string Epdnoaddsubhead2 { get; set; }
        [Column("EPDNOAddsubhead2Txt")]
        [StringLength(500)]
        public string Epdnoaddsubhead2Txt { get; set; }
        [Column("EPDNOAddsubhead3")]
        [StringLength(150)]
        public string Epdnoaddsubhead3 { get; set; }
        [Column("EPDNOAddsubhead3Txt")]
        [StringLength(500)]
        public string Epdnoaddsubhead3Txt { get; set; }
        [Column("EPDDoneby")]
        [StringLength(150)]
        public string Epddoneby { get; set; }
        [Column("EPDDonebyTxt")]
        [StringLength(250)]
        public string EpddonebyTxt { get; set; }
        [Column("EPDDonebyReg")]
        [StringLength(150)]
        public string EpddonebyReg { get; set; }
        [Column("EPDDonebyCon")]
        [StringLength(150)]
        public string EpddonebyCon { get; set; }
        [Column("EPDADDTech")]
        [StringLength(150)]
        public string Epdaddtech { get; set; }
        [Column("EPDADDTechTxt")]
        [StringLength(5000)]
        public string EpdaddtechTxt { get; set; }
        [Column("EPDBuildinglife")]
        [StringLength(250)]
        public string Epdbuildinglife { get; set; }
        [Column("COM_ID")]
        public long? ComId { get; set; }
        [Column("EPDSign")]
        [StringLength(150)]
        public string Epdsign { get; set; }
        [Column("EPDLogo2")]
        [StringLength(150)]
        public string Epdlogo2 { get; set; }
        [Column("ClientGroupsID")]
        public int? ClientGroupsId { get; set; }
        [Column("EPDAuthor")]
        public int? Epdauthor { get; set; }
        [Column("EPDNOAddsubhead4")]
        [StringLength(150)]
        public string Epdnoaddsubhead4 { get; set; }
        [Column("EPDNOAddsubhead4Txt")]
        [StringLength(500)]
        public string Epdnoaddsubhead4Txt { get; set; }
        [Column("EPD3PartyNameID")]
        public long? Epd3partyNameId { get; set; }
        [Column("SUMA1A3")]
        public int? Suma1a3 { get; set; }
        [Column("EPDToolInfo")]
        [StringLength(100)]
        public string EpdtoolInfo { get; set; }
        [Column("EPDToolInfoTxt")]
        [StringLength(600)]
        public string EpdtoolInfoTxt { get; set; }
        [Column("EPDNOAddDanger5")]
        [StringLength(500)]
        public string EpdnoaddDanger5 { get; set; }
        [Column("EPDMainContact")]
        [StringLength(150)]
        public string EpdmainContact { get; set; }
        [Column("EPDPhone")]
        [StringLength(150)]
        public string Epdphone { get; set; }
        [Column("EPDEmail")]
        [StringLength(150)]
        public string Epdemail { get; set; }
        [Column("EPDWeb")]
        [StringLength(150)]
        public string Epdweb { get; set; }
        [Column("EPDFuncUnit")]
        [StringLength(150)]
        public string EpdfuncUnit { get; set; }
        [Column("EPDLCAResultSubTxt")]
        [StringLength(150)]
        public string EpdlcaresultSubTxt { get; set; }
        [Column("EPDOperatorPublisher")]
        [StringLength(150)]
        public string EpdoperatorPublisher { get; set; }
        [Column("EPDAuthorHeading")]
        [StringLength(150)]
        public string EpdauthorHeading { get; set; }
        [Column("EPDToolDeveloperHeading")]
        [StringLength(150)]
        public string EpdtoolDeveloperHeading { get; set; }
        [Column("EPDLCAResultSubTxt2")]
        [StringLength(150)]
        public string EpdlcaresultSubTxt2 { get; set; }
    }
}
