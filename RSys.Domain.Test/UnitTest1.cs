using Microsoft.VisualStudio.TestTools.UnitTesting;
using RSys.Domain.Models;
using RSys.Domain.Validators;
using System.Threading.Tasks;

namespace RSys.Domain.Test
{
    [TestClass]
    public class UnitTest1
    {
        private PersonalInfo personalInfo = new PersonalInfo
        {
            Country = new Country { ContryId = 1, CountryDescription = "Thailand", IsAllowed = true }
                ,
            DOB = System.DateTime.Now.AddYears(-50)
                ,
            Lastname = "lastname"
                ,
            Name = "name"
                ,
            Title = new Title { TitleId = 1, TitleDescription = "Mr." }
        };

        private Occupation occupation = new Occupation
        {
            BusinessType = new BusinessType { BusinessTypeDescription = "description", BusinessTypeId = 1 }
            ,
            JobTitle = "title"
            ,
            Profession = new Profession { Id=1,ProfessionDescription="desc"}
        };

        private Address address = new Address
        {
            House = "house"
            ,
            Work = "work"
        };
        

        [TestMethod]
        public void TestPersonalInfo()
        {
            ///simple empty name test
            personalInfo.Name = "";
            titleValidator titlevalidator = new titleValidator();
            countryValidator countryvalidator = new countryValidator();

            PersonalInfoValidator personalInfoValidator = new PersonalInfoValidator(titlevalidator, countryvalidator);
            var result = personalInfoValidator.Validate(personalInfo);
            Assert.IsFalse(result.IsValid); 

            personalInfo.Name = "name";
            result = personalInfoValidator.Validate(personalInfo);
            Assert.IsTrue(result.IsValid);

            //interface test
            titleValidator.isvalid = false;
            result = personalInfoValidator.Validate(personalInfo);
            Assert.IsFalse(result.IsValid);
        }

        [TestMethod]
        public void TestInfo()
        {
            //simple nested property test
            personalInfo.Name = "";
            titleValidator titlevalidator = new titleValidator();
            countryValidator countryvalidator = new countryValidator();
            professionValidator professionValidator = new professionValidator();

            Questionnaire info = new Questionnaire
            {
                InfoId = "1"
                ,
                PersonalInfo = this.personalInfo
                ,
                Address = this.address
                ,
                Occupation = this.occupation
            };
            businesstypeValidator businesstypevalidator = new businesstypeValidator(); 
            PersonalInfoValidator personalInfoValidator = new PersonalInfoValidator(titlevalidator, countryvalidator);
            OccupationValidator occupationValidator = new OccupationValidator(businesstypevalidator, professionValidator);
            InfoValidator infovalidator = new InfoValidator(occupationValidator, personalInfoValidator);
            var result = infovalidator.Validate(info);
            Assert.IsFalse(result.IsValid); // invalid since name is empty

            // put the name back
            info.PersonalInfo.Name = "name";
            result = infovalidator.Validate(info);
            Assert.IsTrue(result.IsValid);

            // test country not allowed
            info.PersonalInfo.Country.IsAllowed = false;
            result = infovalidator.Validate(info);
            Assert.IsFalse(result.IsValid);

            // test country allow
            info.PersonalInfo.Country.IsAllowed = true;
            result = infovalidator.Validate(info);
            Assert.IsTrue(result.IsValid);
        }
    }
    class titleValidator : ITitleValidator
    {
        public static bool isvalid = true;
        public Task<bool> IsTitleExistedAsync(int title)
        {
            return Task<bool>.Run(() =>
            {
                return isvalid;
            }); 
        }
    }

    class countryValidator : ICountryValidator
    {
        public static bool isvalid = true;

        public Task<bool> IsCountryExistedAsync(int country)
        {
            return Task<bool>.Run(() =>
            {
                return isvalid;
            });
        }
    }
    class businesstypeValidator : IBusinessTypeValidator
    {
        public static bool isvalid = true;

        public Task<bool> IsBusinessTypeExistedAsync(int businessType)
        {
            return Task<bool>.Run(() =>
            {
                return isvalid;
            });
        }
    }

    class professionValidator : IProfessionValidator
    {
        public static bool isvalid = true;
        public Task<bool> IsProfessionExistedAsync(int proffession)
        {
            return Task<bool>.Run(() =>
            {
                return isvalid;
            });
        }
    }
}
