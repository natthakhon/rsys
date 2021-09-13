"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.PersonalInfoComponent = void 0;
var core_1 = require("@angular/core");
var forms_1 = require("@angular/forms");
var http_1 = require("@angular/common/http");
var questionnaire_1 = require("../vm/questionnaire");
var address_1 = require("../vm/address");
var title_service_1 = require("../service/title.service");
var country_service_1 = require("../service/country.service");
var profession_service_1 = require("../service/profession.service");
var businesstype_service_1 = require("../service/businesstype.service");
var qnaire_service_1 = require("../service/qnaire.service");
var uuid_1 = require("uuid");
var occupation_1 = require("../vm/occupation");
var personalinfo_1 = require("../vm/personalinfo");
var PersonalInfoComponent = /** @class */ (function () {
    function PersonalInfoComponent(fb, http) {
        this.fb = fb;
        this.http = http;
    }
    PersonalInfoComponent.prototype.ngOnInit = function () {
        this.iniForm();
        this.gettitles();
        this.getcountries();
        this.getprofessions();
        this.getbusinesstypes();
        this.getqnaires();
    };
    PersonalInfoComponent.prototype.gettitles = function () {
        var _this = this;
        var titleservice = new title_service_1.TitleService(this.http);
        titleservice.gettitles().subscribe(function (data) {
            _this.titles = data;
        });
    };
    PersonalInfoComponent.prototype.getcountries = function () {
        var _this = this;
        var countryservice = new country_service_1.CountryService(this.http);
        countryservice.getcountries().subscribe(function (data) {
            _this.countries = data;
        });
    };
    PersonalInfoComponent.prototype.getprofessions = function () {
        var _this = this;
        var professionservice = new profession_service_1.ProfessionService(this.http);
        professionservice.getprofessions().subscribe(function (data) {
            _this.professions = data;
        });
    };
    PersonalInfoComponent.prototype.getbusinesstypes = function () {
        var _this = this;
        var businesstypeservice = new businesstype_service_1.BusinesstypeService(this.http);
        businesstypeservice.getbusinesstypes().subscribe(function (data) {
            _this.businesstypes = data;
        });
    };
    PersonalInfoComponent.prototype.getqnaires = function () {
        var _this = this;
        var qnaireservice = new qnaire_service_1.QnaireService(this.http);
        qnaireservice.getqnaires().subscribe(function (data) {
            _this.qnaires = data;
        });
    };
    PersonalInfoComponent.prototype.iniForm = function () {
        this.questions = this.fb.group({
            title: [''],
            name: [''],
            lastname: [''],
            dob: [],
            country: [],
            house: [],
            work: [],
            profession: [],
            jobtitle: [],
            businesstype: []
        });
    };
    PersonalInfoComponent.prototype.save = function () {
        var qnaire = new questionnaire_1.questionnaire();
        //console.log(uuidv4());
        qnaire.InfoId = (0, uuid_1.v4)();
        qnaire.Address = new address_1.address();
        qnaire.Address.House = this.questions.controls['house'].value;
        qnaire.Address.Work = this.questions.controls['work'].value;
        qnaire.CreateDate = new Date();
        qnaire.Occupation = new occupation_1.occupation();
        qnaire.Occupation.JobTitle = this.questions.controls['jobtitle'].value;
        qnaire.Occupation.BusinessType = this.questions.controls['businesstype'].value;
        qnaire.Occupation.Profession = this.questions.controls['profession'].value;
        qnaire.PersonalInfo = new personalinfo_1.personalInfo();
        qnaire.PersonalInfo.Country = this.questions.controls['country'].value;
        qnaire.PersonalInfo.DOB = this.questions.controls['dob'].value;
        qnaire.PersonalInfo.Lastname = this.questions.controls['lastname'].value;
        qnaire.PersonalInfo.Name = this.questions.controls['name'].value;
        qnaire.PersonalInfo.Title = this.questions.controls['title'].value;
        var qnaireservice = new qnaire_service_1.QnaireService(this.http);
        qnaireservice.postqnaire(qnaire).subscribe(function (data) {
            alert('done');
        }, function (e) { alert(e.error); });
    };
    PersonalInfoComponent = __decorate([
        (0, core_1.Component)({
            selector: 'app-personal-info',
            templateUrl: './personal-info.component.html',
            styleUrls: ['./personal-info.component.css']
        }),
        __metadata("design:paramtypes", [forms_1.FormBuilder,
            http_1.HttpClient])
    ], PersonalInfoComponent);
    return PersonalInfoComponent;
}());
exports.PersonalInfoComponent = PersonalInfoComponent;
//# sourceMappingURL=personal-info.component.js.map