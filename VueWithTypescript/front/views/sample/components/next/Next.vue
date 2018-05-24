<template>
    <div>
        <h2>Get and post test.</h2>
        <div class="row">
            <div class="col-md-4">Received on before route enter</div>
            <div class="col-md-4">{{receivedOnBeforeRouteEnter}}</div>
        </div>
        <div class="row">
            <div class="col-md-4">Received on created</div>
            <div class="col-md-4">{{receivedOnCreated}}</div>
        </div>
        <div class="row">
            <div class="col-md-4"><input v-model="inputData" placeholder="Input any." /><a href="javascript: void(0)" @click="postButtonClicked()">Post</a></div>
            <div class="col-md-4">{{postResult}}</div>
        </div>
        <div class="row"><router-link :to="{name: 'index'}" class="btn btn-primary btn-lg">Back</router-link></div>
    </div>
</template>

<script lang="ts">
    import {Vue, Component} from "vue-property-decorator";
    import axios from 'axios';
    import {GetTestData} from "./response/TestData";
    import {PostTestData} from "./response/PostTestData";

    @Component
    export default class SharedServerIndexComponent extends Vue{
        public receivedOnBeforeRouteEnter: string = "";
        public receivedOnCreated: string = "";
        public inputData:string = "";
        public postResult:string = "";

        // called before instantiated component
        beforeRouteEnter(to: any, from: any, next: any){
            axios.get<GetTestData>("/Sample/GetTest")
                .then(res=> {
                    const response = res.data;
                    next(component => {
                        component.receivedOnBeforeRouteEnter = response.testData;
                    })
                });
        }

        // called after mount
        created(){
            axios.get<GetTestData>("/Sample/GetTest")
                .then(res=> {
                    const response = res.data;
                    this.receivedOnCreated = response.testData;
                });
        }

        postButtonClicked(){
            console.log("clicked")
            const request = {
                testText: this.inputData
            };
            axios.post<PostTestData>("/Sample/PostTest", request)
                .then(res=> {
                    const response = res.data;
                    this.postResult = response.testText;
                });
        }
    }
</script>