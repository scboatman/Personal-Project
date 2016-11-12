namespace LoadShareWebApp.Controllers {

    export class TruckDetailController{
        public message = "Hello from the Truck Detail page!"
        private TruckDetailResource;
        public TruckDetail;
        public truckDetails;

        public getTruckDetails() {
        this.truckDetails = this.TruckDetailResource.query();
    }
        public save() {
        this.TruckDetailResource.save(this.TruckDetail).$promise.then(() => {
            this.TruckDetail = null;
            this.getTruckDetails();
        });
    }

    constructor(private $resource: angular.resource.IResourceService) {
        this.TruckDetailResource = $resource('/api/truckDetails/:id');
        this.getTruckDetails();
        }
     
        
    }
}




