<template>
    <div class="container-fluid">
        <div class="row">
            <DashboardHeader />
            <div class="col-12 p-4 bg-dark text-light mb-4">
                <h2>
                    Task details
                </h2>
            </div>
            <div class="col-12 pb-5">
                <div class="row">
                    <div class="col-12 mb-3">
                        <div class="card text-left" v-if='showTask'>
                            <div class="card-body" >
                                <!--<strong class="float-right">-->
                                    <!--&lt;!&ndash;{{ createdAt | formatDate }}&ndash;&gt;-->
                                <!--</strong>-->
                                <div class="info-task">
                                    <p>Created: {{ createdAt | formatDate }}</p>
                                    <p v-if="isCompleted">Completed: {{ completedAt | formatDate }}</p>
                                    <p v-else>Not finished</p>
                                </div>
                                <h2 class="card-title">{{ title }}</h2>
                                <p class="card-text"> {{ username }}</p>
                                <div class="employee-grade">
                                    <p>Actual time passed for task </p>
                                    <p>{{ actualTimePassed }}</p>
                                </div>
                                <div class="employee-grade">
                                    <p>Estimeted time for task </p>
                                    <p>{{ timeEstimatedByWorker }}</p>
                                </div>
                                <div class="employee-grade">
                                    <p>Grade from lider</p>
                                    <p>{{ resultGradeByLeader }}</p>
                                </div>
                                <div class="employee-grade">
                                    <p>Grade from employee</p>
                                    <p>{{ resultGradeByWorker }}</p>
                                </div>
                                <div class="employee-grade">
                                    <p>Dificulty from lider</p>
                                    <p>{{ dificultyGradeByLeader }}</p>
                                </div>
                                <div class="employee-grade">
                                    <p>Dificulty from employee</p>
                                    <p>{{ dificultyGradeByWorker }}</p>
                                </div>
                                <div class="smallDividerBlock mt-5 mb-5"></div>
                                <p class="card-text text-center"> {{ description }}</p>
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
  data: () => {
    return {
      username: "",
      title: "",
      createdAt: "",
      completedAt: "",
      timeEstimatedByWorker: "",
      isCompleted: "",
      actualTimePassed: "",
      resultGradeByLeader: "",
      resultGradeByWorker: "",
      dificultyGradeByLeader: "",
      dificultyGradeByWorker: "",
      description: "",
      showTask: false
    };
  },
  components: {
    DashboardHeader: DashboardHeader,
    DashboardFooter: DashboardFooter
  },
  mounted: function() {
    let self = this;

    this.$axios
      .get("http://kathon.hackierz.com/Teams/One/1")
      .then(function(req) {
        self.tasks = req.data.tasks.map(objects => {
          if (objects.id == self.$route.params.taskId) {
            self.showTask = true;
            self.username = objects.username;
            self.title = objects.title;
            self.createdAt = objects.createdAt;
            self.timeEstimatedByWorker = objects.timeEstimatedByWorker;
            self.isCompleted = objects.isCompleted;
            self.completedAt = objects.completedAt;
            self.actualTimePassed = objects.actualTimePassed;
            self.resultGradeByLeader = objects.resultGradeByLeader;
            self.resultGradeByWorker = objects.resultGradeByWorker;
            self.description = objects.description;
            self.dificultyGradeByLeader = objects.dificultyGradeByLeader;
            self.dificultyGradeByWorker = objects.dificultyGradeByWorker;
          }
        });
      });
  }
};
</script>

<style scoped lang="scss">
    .info-task {
        display: flex;
        justify-content: space-between;
    }
    .employee-grade {
        display: flex;
        width: 20%;
        justify-content: space-between;
    }
</style>
