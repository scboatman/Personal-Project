namespace LoadShareWebApp.Controllers {

   
    export class TruckController {
        public message = "Hello from the Truck page!"
        private TruckResource;
        public Truck;
        public trucks;

        public getTrucks() {
            this.trucks = this.TruckResource.query();
        }
        public save() {
            this.TruckResource.save(this.Truck).$promise.then(() => {
                this.Truck = null;
                this.getTrucks();
            });
        }

        constructor(private $resource: angular.resource.IResourceService) {
            this.TruckResource = $resource('/api/trucks/:id');
            this.getTrucks();
        }
    }
    
    


}


