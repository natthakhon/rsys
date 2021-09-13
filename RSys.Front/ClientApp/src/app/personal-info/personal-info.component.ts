import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { HttpClient, } from '@angular/common/http';
import { title } from '../vm/title'
import { country } from '../vm/country'
import { businesstype } from '../vm/businesstype'
import { profession } from '../vm/profession'
import { questionnaire } from '../vm/questionnaire'
import { address } from '../vm/address'
import { TitleService } from '../service/title.service'
import { CountryService } from '../service/country.service';
import { ProfessionService } from '../service/profession.service';
import { BusinesstypeService } from '../service/businesstype.service';
import { QnaireService } from '../service/qnaire.service';
import { v4 as uuidv4 } from 'uuid';
import { occupation } from '../vm/occupation';
import { personalInfo } from '../vm/personalinfo';

@Component({
  selector: 'app-personal-info',
  templateUrl: './personal-info.component.html',
  styleUrls: ['./personal-info.component.css']
})

export class PersonalInfoComponent implements OnInit {

  questions: FormGroup;
  titles: title[];
  countries: country[];
  professions: profession[];
  businesstypes: businesstype[];
  qnaires: questionnaire[];

  constructor(private fb: FormBuilder
    , private http: HttpClient  ) { }

  ngOnInit() {
    this.iniForm();
    this.gettitles();
    this.getcountries();
    this.getprofessions();
    this.getbusinesstypes();
    this.getqnaires();
  }

  gettitles() {
    const titleservice = new TitleService(this.http);
    titleservice.gettitles().subscribe(data => {
      this.titles = data;
    })
  }

  getcountries() {
    const countryservice = new CountryService(this.http);
    countryservice.getcountries().subscribe(data => {
      this.countries = data;
    })
  }

  getprofessions() {
    const professionservice = new ProfessionService(this.http);
    professionservice.getprofessions().subscribe(data => {
      this.professions = data;
    })
  }

  getbusinesstypes() {
    const businesstypeservice = new BusinesstypeService(this.http);
    businesstypeservice.getbusinesstypes().subscribe(data => {
      this.businesstypes = data;
    })
  }

  getqnaires() {
    const qnaireservice = new QnaireService(this.http);
    qnaireservice.getqnaires().subscribe(data => {
      this.qnaires = data;
    })
  }

  iniForm() {
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
      businesstype:[]
    });
  }

  save() {
    let qnaire = new questionnaire();
    //console.log(uuidv4());
    qnaire.InfoId = uuidv4();

    qnaire.Address = new address();
    qnaire.Address.House = this.questions.controls['house'].value;
    qnaire.Address.Work = this.questions.controls['work'].value;

    qnaire.CreateDate = new Date();

    qnaire.Occupation = new occupation();
    qnaire.Occupation.JobTitle = this.questions.controls['jobtitle'].value;
    qnaire.Occupation.BusinessType = this.questions.controls['businesstype'].value;
    qnaire.Occupation.Profession = this.questions.controls['profession'].value;

    qnaire.PersonalInfo = new personalInfo();
    qnaire.PersonalInfo.Country = this.questions.controls['country'].value;
    qnaire.PersonalInfo.DOB = this.questions.controls['dob'].value;
    qnaire.PersonalInfo.Lastname = this.questions.controls['lastname'].value;
    qnaire.PersonalInfo.Name = this.questions.controls['name'].value;
    qnaire.PersonalInfo.Title = this.questions.controls['title'].value;

    const qnaireservice = new QnaireService(this.http);
    qnaireservice.postqnaire(qnaire).subscribe(data => {
      alert('done');
    }, e => { alert(e.error);})
  }
}
