<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-5">
			    <div class="xd">
			    	<h2>
			    		Member Types
			    	</h2>
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
