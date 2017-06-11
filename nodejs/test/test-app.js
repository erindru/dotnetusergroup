let chai = require("chai");
let chaiHttp = require("chai-http");
let expect = chai.expect;
let app = require("../app/app");

// Add the Chai module that allows Chai to recognise express.js server objects
chai.use(chaiHttp);

describe("Main controller test", function() {

	it("should redirect to /hello if / is hit", function (done) {
		chai.request(app).get("/").redirects(0).end(function(err, res) {
			expect(res.status).to.equal(302);
			expect(res.headers.location).contain("/hello");
			done();
		});
	});

	it("should return hello, world when no specific name is specified", function(done) {
		chai.request(app).get("/hello").end(function(err, res) {
			expect(res.status).equal(200);
			expect(res.text).equal("Hello World!")
			done();
		});
	});

	it("should return hello, {name} when a name is specified", function(done) {
		chai.request(app).get("/hello/nodejs").end(function(err, res) {
			expect(res.status).to.equal(200);
			expect(res.text).equal("Hello nodejs!")
			done();
		})
	});
});