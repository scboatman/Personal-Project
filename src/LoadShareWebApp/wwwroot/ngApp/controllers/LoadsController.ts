namespace LoadShareWebApp.Controllers{

    export class LoadController {
        public message = "Hello from the Load page!"
        private LoadResource;
        public Load;
        public loads;

        public getLoads() {
            this.loads = this.LoadResource.query()
        }
        //public save() {
        //    this.LoadResource.save(this.Load).$promise.then(() => {
        //        this.Load = null;
        //        this.getLoads();
        //    });
        //}

        constructor(private $resource: angular.resource.IResourceService) {
            this.LoadResource = $resource('/api/loads/');
            this.getLoads();
        }
    }
}