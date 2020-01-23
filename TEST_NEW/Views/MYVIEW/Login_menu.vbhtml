
<h2 style="color: red;border: solid;text-align: center;">Login_menu</h2>
<br />
<br />
<div style="font-size:16px">
    <table>
        <tr>
            <td>
                <label>USERNAME</label> :
            </td>
            <td>
                <input type="text" ng-model="FULL_MODEL.USERNAME" />
            </td>
        </tr>
        <tr>
            <td>
                <label>PASSWORD</label> :
            </td>
            <td>
                <input type="text"  ng-model="FULL_MODEL.PASSWORD" />
                </td>
        </tr>
        <tr>
            <td colspan="2"><button ng-click="BTN_LOGIN()">LOGIN</button></td>
        </tr>
    </table>
    <button ng-click="BTN_REGISTER(FULL_MODEL.USERNAME,FULL_MODEL.PASSWORD)">REGISTER</button>
    <button ng-click="BTN_SEL()">SELECT_PASSWORD</button>
    <button ng-click="BTN_EDIT()">EDIT_PASSWORD</button>
    <button ng-click="BTN_DEL(FULL_MODEL.USERNAME)">DEL_USER</button>
    <button ng-click="BTN_CLEAR()"> BTN_CLEAR</button>
   <div>
       <table class="table-bordered">
           <thead >
               <tr>
                   <th>IDA</th>
                   <th>USER</th>
                   <th>PASSWORD</th>
                   <th></th>
                   <td></td>
               </tr>
           </thead>
         
           <tbody>
               <tr ng-repeat="datas in FULL_MODEL.DETAIL_DATA">
                   <td>{{datas.IDA}}</td>
                   <td>{{datas.USERNAME}}</td>
                   <td>{{datas.PASSWORD}}</td>
                   <td><button ng-click="SEL_DATA(datas)">เลือก</button></td>
                   <td><button ng-click="BTN_DEL(datas.USERNAME)">เลือก</button></td>
               </tr>
           </tbody>
       </table>
   </div>
    <br />
   
    
</div>