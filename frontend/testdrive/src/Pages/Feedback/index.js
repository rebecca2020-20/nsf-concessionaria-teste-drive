import React, { useState } from "react";
import { Link } from "react-router-dom";

export default function MenuCliente(props){

    const [infos, setInfos] = useState(props.location.state);

    return(
        <div className="d-flex flex-column align-items-center justify-content-center" style={{minHeight:"90vh", minWidth:"100vw"}}>
            <div className="text-center">
                <input type="number"></input>
            </div>
        </div> 
    )
}