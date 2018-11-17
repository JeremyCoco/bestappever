<template>
    <div class="container-fluid">
        <div class="row">
            <DashboardHeader />
            <div class="col-12 p-4 bg-dark text-light mb-4">
                <h2>
                    Member details
                </h2>
            </div>
            <div class="col-12 pb-5">
                <div class="row">
                    <div class="col-12 mb-3">
                        <div class="card text-left">
                            <div class="card-body" >
                                <h1>Prepare</h1>
                                <div class="member">
                                    <label>Employee ID</label>
                                    <input type="text" class="form-control" v-model="PersonId"/>
                                </div>
                                <div class="member">
                                    <label>Predispositions</label>
                                    <b-form-select :options="options" class="mb-3" v-model="dataType"/>
                                </div>
                                <div class="member">
                                    <label>Expected result</label>
                                    <b-form-select :options="options2" class="mb-3" v-model="resultType"/>
                                </div>
                                <button @click="prepareDataset()" class="btn btn-primary mt-5 float-right">Send</button>
                                <div v-show="spinner" ><breeding-rhombus-spinner :animation-duration="2000" :size="35" color="#84c8fb" /></div>
                                <div style="text-align: center"><p>{{ learningSucces }}</p></div>
                            </div>
                        </div>
                    </div>
                    <div class="col-12 mb-3">
                        <div class="card text-left">
                            <div class="card-body" >
                                <h1>Compute</h1>
                                <div class="member">
                                    <label>Employee ID</label>
                                    <input type="text" class="form-control" v-model="PersonId"/>
                                </div>
                                <div class="member">
                                    <label>Estimated time</label>
                                    <input type="text" class="form-control" v-model="TimeExpected"/>
                                </div>
                                <div class="member">
                                    <label>Final time</label>
                                    <input type="text" class="form-control" v-model="TimeReal"/>
                                </div>
                                <div class="member">
                                    <label>Estimated difficulty</label>
                                    <input type="text" class="form-control" v-model="DifficultyWorker"/>
                                </div>
                                <div class="member">
                                    <label>Final difficulty</label>
                                    <input type="text" class="form-control" v-model="DifficultyLeader"/>
                                </div>
                                <button @click="computeDataset()" class="btn btn-primary mt-5 float-right">Send</button>
                                <div v-show="spinner" ><breeding-rhombus-spinner :animation-duration="2000" :size="35" color="#84c8fb" /></div>
                                <div style="text-align: center"><p>{{ computeSucces }}</p></div>
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
import { BreedingRhombusSpinner } from 'epic-spinners'

export default {
  data() {
    return {
      dataType: null,
      resultType: null,
      options: [
        { value: null, text: "Please select an option" },
        {
          value: 0,
          text: "Employee copes best with quick and hard assigments"
        },
        {
          value: 1,
          text: "Employee copes best with quick and easy assigments"
        },
        { value: 2, text: "Employee copes best with long and hard assigments" },
        { value: 3, text: "Employee copes best with long and easy assigments" }
      ],
      options2: [
        { value: null, text: "Please select an option" },
        {
          value: 0,
          text: "Employee will perform assigment without any problems"
        },
        { value: 1, text: "Employee will perform assigment indifferently" },
        {
          value: 2,
          text: "Employee will perform assigment with some problems"
        },
        { value: 3, text: "Employee won't perform assigment at all" }
      ],
      PersonId: "",
      TimeExpected: "",
      TimeReal: "",
      DifficultyWorker: "",
      DifficultyLeader: "",
      learningSucces: "",
      computeSucces: "",
      spinner: false
    };
  },
  components: {
    DashboardHeader: DashboardHeader,
    DashboardFooter: DashboardFooter,
    BreedingRhombusSpinner
  },
  methods: {
    computeDataset() {
      let self = this;
      this.computeSucces = "";
      this.spinner = true;
      this.$axios
        .get(`http://neuralapi.hackierz.com/api/values/${this.PersonId}/${this.TimeExpected}/${this.TimeReal}/${this.DifficultyWorker}/${this.DifficultyLeader}`)
        .then((respond) => {
          if (respond.data) {
            self.computeSucces = "Learning finished.";
            self.spinner = false;
          } else {
            self.computeSucces = "Learning failed.";
            self.spinner = false;
          }
        });
    },
    prepareDataset() {
      let self = this;
      this.learningSucces = "";
      this.spinner = true;
      this.$axios
        .get(`http://neuralapi.hackierz.com/api/values/${this.PersonId}/${this.dataType}/${this.resultType}`)
        .then((respond) => {
          if (respond.data) {
            self.learningSucces = "Learning finished.";
            self.spinner = false;
          } else {
            self.learningSucces = "Learning failed.";
            self.spinner = false;
          }
        });
    }
  },

};
</script>

<style scoped lang="scss">
    .breeding-rhombus-spinner {
        position: absolute;
        left: 50%;
        top: 80%;
    }
</style>
