namespace LoadShareWebApp.Controller{

    export class LoadController {
        private LoadResource;
        public Truck;
        public trucks;

        public getTrucks() {
            this.trucks = this.LoadResource.query();
        }
        public save() {
            this.LoadResource.save(this.Truck).$promise.then(() => {
                this.Truck = null;
                this.getTrucks();
            });
        }

        constructor(private $resource: angular.resource.IResourceService) {
            this.LoadResource = $resource('/api/trucks/:id');
            this.getTrucks();
        }
    }
}