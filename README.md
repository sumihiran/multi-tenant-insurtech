## InsurTechCore

A Software as a service (SaaS) company providing B2B solutions for the digital disruption in insurance.

## Goal

- Build a proof of concept product that is **elastically scalable**, cloud agnostic and regulatory compliant **(GDPR)**. 
- Utilize TDD methodology for development.
- Keep code coverage around 100% and test coverage up 70%.
- Each module should follow hexagonal architecture.

## Implementation

### Domain 

- [ ] Identify complexities of (sub)domains / bounded-contexts with [Cynefin Framework](https://hbr.org/2007/11/a-leaders-framework-for-decision-making)
- [ ] Event-storming 

### Codebase

- [ ] GraphQL schema stitching
- [ ] Integrate EventstoreDB with Masstransit
  - [ ] Aggregates
  - [ ] Saga
  - [ ] Event serialization with [crypto-shredding](https://www.seald.io/blog/data-destruction-using-crypto-shredding)

### DevOps 

- [ ] Cake Tool
- [ ] GitHub Actions
  - [ ] Coverage report
- [ ] Service discovery on k8s
- [ ] Health checks

## Resources

- [Domain-Driven Design Use Case: Improving A Life Insurance Selling Platform](https://www.blog.jamesmichaelhickey.com/DDD-Use-Case-Life-Insurance-Platform/) - James Hickey 
- [Insurtech Insider](https://podcasts.apple.com/no/podcast/insurtech-insider-podcast-by-11-fs/id1330999202?l=nb) Podcast by 11:FS
- CoverGo - InsurTech Platform [GraphQL API](https://api.covergo.com/playground)

