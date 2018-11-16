<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-4 bg-success text-light mb-4">
		    	<h2>
		    		Member Types
		    	</h2>
		    </div>
		    <div class="col-12 pb-5">
			    <div class="row">
				    <div class="col-12 mb-3">
						<div class="card text-left memberTypeCard border-success">
							<div class="card-body">
								
								<h5 class="card-title">
									Title name
								</h5>
								<p class="card-text">
									Example tasks: 
									<i>
										task name
									</i>
								</p>
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

.memberTypeCard {
	text-decoration: none;
	color: initial;
}

.memberTypeCard:hover {
	text-decoration: none;
	color: initial;
	filter: drop-shadow(3px 6px 3px rgba(0, 0, 0, 0.6));
	
}
</style>
