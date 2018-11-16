<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-5">
		    	<h2>
		    		Current Tasks
		    	</h2>
			    <div class="row">
				    <div class="col-12">
				    	dsds
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
