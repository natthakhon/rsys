import { personalInfo } from '../vm/personalinfo'
import { address } from '../vm/address'
import { occupation } from '../vm/occupation'

export class questionnaire {
  InfoId: string
  PersonalInfo: personalInfo
  Address: address
  Occupation: occupation
  CreateDate: Date
}
