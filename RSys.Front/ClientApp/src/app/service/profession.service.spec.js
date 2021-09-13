"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var profession_service_1 = require("./profession.service");
describe('ProfessionService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(profession_service_1.ProfessionService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=profession.service.spec.js.map