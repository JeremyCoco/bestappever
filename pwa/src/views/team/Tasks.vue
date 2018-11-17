<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-4 bg-dark text-light mb-4">
		    	<h2>
		    		Current Tasks
		    	</h2>
		    </div>
		    <div class="col-12 pb-5">
			    <div class="row">
				    <div class="col-12 mb-3">
						<div class="card text-left">
							<div class="card-body">
								<strong class="float-right">
									data dodania
								</strong>
								<h5 class="card-title">Task Name</h5>
								<p class="card-text">
									data dodania
								</p>
								<a href="#" class="btn btn-primary">Go to details</a>
							</div>
						</div>
				    </div>
				    <div class="col-12">
						<div class="card text-left">
							<div class="card-body">
								<strong class="float-right text-danger">
									no employee assigned
								</strong>
								<h5 class="card-title">Task Name</h5>
								<p class="card-text">
									data dodania
								</p>
								<a href="#" class="btn btn-primary">Go to details</a>
							</div>
						</div>
				    </div>
			    </div>
		    </div>
		    <DashboardFooter />
	    </div>
    </div>
</template>

<script>
	import DashboardHeader from "@/components/DashboardHeader";
	import DashboardFooter from "@/components/DashboardFooter";

	export default {
		components: {
			"DashboardHeader": DashboardHeader,
			"DashboardFooter": DashboardFooter
		}
	};
</script>

<style scoped>
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;

}
</style>
