<template>
    <div class="container-fluid">
	    <div class="row">
		    <DashboardHeader />
		    <div class="col-12 p-5">
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
    DashboardHeader: DashboardHeader,
    DashboardFooter: DashboardFooter
  },
  mounted: function() {
    // this.$axios
    //   .get("http://kathon.hackierz.com/Teams/one/1")
    //   .then(function(data) {
    //     console.log(data.data);
    //   });
  },
  methods: {
    // getCosik() {
    //   this.$axios.get("http://kathon.hackierz.com/Teams").then(function(data) {
    //     console.log(data);
    //   });
    // }
  }
};
</script>

<style scoped>
.dashboardTopHeader {
  background: url(/img/app_bg.png) no-repeat center center;
  background-size: cover;
}
</style>
