<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-4 bg-dark text-light mb-4">
		    	<h2>
		    		Members
		    	</h2>
		    </div>
		    <div class="col-12 p-5">
			    <div class="row">
				    <div class="col-12 mb-3">
						<a href="#" class="card text-left memberCard">
							<div class="card-body">
								<h5 class="card-title">
									Name and surname
								</h5>
								<p class="card-text">
									Assigned tasks:
									<strong>
									<span class="text-warning">250</span>, of which <span class="text-success">230</span> completed
								</strong>
								</p>
							</div>
						</a>
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

.memberCard {
	text-decoration: none;
	color: initial;
	
}

.memberCard:hover {
	text-decoration: none;
	color: initial;
	filter: drop-shadow(3px 6px 3px rgba(0, 0, 0, 0.6));
	
}
</style>
