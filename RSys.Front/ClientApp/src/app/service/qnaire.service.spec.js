"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var testing_1 = require("@angular/core/testing");
var qnaire_service_1 = require("./qnaire.service");
describe('QnaireService', function () {
    beforeEach(function () { return testing_1.TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = testing_1.TestBed.get(qnaire_service_1.QnaireService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=qnaire.service.spec.js.map