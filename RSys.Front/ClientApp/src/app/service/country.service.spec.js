"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var country_service_1 = require("./country.service");
describe('CountryService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(country_service_1.CountryService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=country.service.spec.js.map